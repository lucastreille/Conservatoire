
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conservatoire.vues;
using Conservatoire.Vues;
using Conservatoire.DAL;
using Conservatoire.controleurs;
using Conservatoire.Modele;

namespace Conservatoire.vues
{
    public partial class listPorfesseur : Form
    {

        Mgr monManager = new Mgr();
        List<Prof> ListeProf = new List<Prof>();

        public listPorfesseur()
        {
            InitializeComponent();

        }

        private void listPorfesseur_Load(object sender, EventArgs e)
        {

            ListeProf = monManager.chargementEmpBD();

            if (ListeProf.Count() == 0)
            { 

                VoirCours.Hide();
                button3.Hide();
                button2.Hide();

            }
            else
            {
                affiche();
            }

        }


        public void affiche()

        {


            try
            {

                listBox1.DataSource = null;
                listBox1.DataSource = ListeProf;
                listBox1.DisplayMember = "Description";

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void VoirCours_Click(object sender, EventArgs e)
        {
            Prof Pr = (Prof)listBox1.SelectedItem;

            listeCours lc = new listeCours(Pr);

            lc.ShowDialog();

        }



        //Ajouter un professeur
        private void button1_Click(object sender, EventArgs e)
        {

            gestionProf ajouterUnProf = new gestionProf(); //envoi vers le constructeur classique
            ajouterUnProf.ShowDialog();

        }



        //modifier un professeur
        private void button3_Click(object sender, EventArgs e)
        {

            Prof Pr = (Prof)listBox1.SelectedItem;

            gestionProf modifierUnProf = new gestionProf(Pr); //envoi vers le constructeur surchargé
            modifierUnProf.ShowDialog();

        }



        //Supprimer un professeur
        private void button2_Click(object sender, EventArgs e)
        {

            Prof Pr = (Prof)listBox1.SelectedItem;
            int idProf = Pr.Num;


            bool etatSupression = monManager.supressionProf(idProf);

            if (etatSupression == true)
            {
                MessageBox.Show("Professeur supprimé");
            }
            else
            {
                MessageBox.Show("Supression impossible car ce professeur à au moins 1 cours attribué !");
            }

            reactualisation();


        }



        //Permet de réactualiser la listeBox
        public void reactualisation()
        {

            ListeProf = monManager.chargementEmpBD();

            if (ListeProf.Count() == 0)
            {

                VoirCours.Hide();
                button3.Hide();
                button2.Hide();

            }
            else
            {

                VoirCours.Show();
                button3.Show();
                button2.Show();

                affiche();
            }

        }


        //Ouvre l'interface des paiement
        private void button4_Click(object sender, EventArgs e)
        {

            listePaimentEleve paimentEleve = new listePaimentEleve(); //envoi vers le constructeur surchargé
            paimentEleve.ShowDialog();

        }

       
    }
}
