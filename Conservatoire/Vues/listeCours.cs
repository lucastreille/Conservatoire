using Conservatoire.controleurs;
using Conservatoire.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Conservatoire.Vues
{
    public partial class listeCours : Form
    {



        private Prof Pr;

        Mgr monManager = new Mgr();
        List<Cours> ListeCours = new List<Cours>();




        public listeCours(Prof unProf)
        {
            InitializeComponent();
            this.Pr = unProf;
        }


        private void listeCours_Load(object sender, EventArgs e)
        {

            int idProf = Pr.Num;
            ListeCours = monManager.chargementListeCours(idProf);


            //Controle le nombre de cours
            if (ListeCours.Count() == 0)
            {
                button1.Hide();
                button2.Hide();
                button4.Hide();
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
                listBox1.DataSource = ListeCours;
                listBox1.DisplayMember = "Description";

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        //Consulter les évlèves du cours
        private void button1_Click(object sender, EventArgs e)
        {
            Cours Crs = (Cours)listBox1.SelectedItem;

            listeEleve AffichageListeEleve = new listeEleve(Crs);

            AffichageListeEleve.ShowDialog();

        }

        //Mofication du cours
        private void button2_Click(object sender, EventArgs e)
        {

            Cours Crs = (Cours)listBox1.SelectedItem;

            gestionCours AffichageGestionCours = new gestionCours(Crs);//id prof transférer pour l'actualisation à la fermeture de la fenêtre
            AffichageGestionCours.ShowDialog();

        }


        //Ajout d'un cours
        private void button3_Click(object sender, EventArgs e)
        {

            int idProf = Pr.Num;

            Console.WriteLine(idProf);
            gestionCours AffichageGestionCours = new gestionCours(idProf); //id prof transférer pour l'actualisation à la fermeture de la fenêtre
            AffichageGestionCours.ShowDialog();

        }


        //suppression d'un cours
        private void button4_Click(object sender, EventArgs e)
        {


            Cours Crs = (Cours)listBox1.SelectedItem;
            int numSeance = Crs.Numseance;


            bool etatSupression = monManager.suppressionCours(numSeance);

            if (etatSupression == true)
            {
                MessageBox.Show("Cours supprimé");
            }
            else
            {
                MessageBox.Show("Suppression impossible car ce cours à au moins 1 élève attribué");

            }


            reactualisation();

        }



        public void reactualisation()
        {

            int idProf = Pr.Num;
            Console.WriteLine(idProf);
            ListeCours = monManager.chargementListeCours(idProf);

            //Controle le nombre de cours
            if (ListeCours.Count() == 0)
            {

                button1.Hide();
                button2.Hide();
                button4.Hide();

                affiche();
            }
            else
            {
                button1.Show();
                button2.Show();
                button4.Show();

                affiche();
            }

        }




    }
}
