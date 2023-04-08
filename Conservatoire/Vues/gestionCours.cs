using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conservatoire.Modele;
using Conservatoire.controleurs;

namespace Conservatoire.Vues
{
    public partial class gestionCours : Form
    {


        Mgr monManager = new Mgr();
        

        int idProf;
        int numSeance;
        string jour;
        string tranche;
        int niveauCours;
        int capaciteCours;


        Cours cour;
        



        //Ajout d'un cours
        public gestionCours(int unidProf)
        { 

            InitializeComponent();

            idProf = unidProf;

            int dernierId = monManager.recuperationDernierSeance();
            numInput.Text = Convert.ToString(dernierId + 1);

            label3.Text = "Ajout d'un cours";

            button2.Show();//Ajout
            button1.Hide();//Modification

        }


        //Surcharge du constructeur lors de la modification d'un cours
        public gestionCours(Cours Crs)
        {
            InitializeComponent();
          

            idProf = Crs.IdProf;
            numSeance = Crs.Numseance;
            jour = Crs.Jour;
            tranche = Crs.Tranche;
            niveauCours = Crs.Niveau;
            capaciteCours = Crs.Capacite;
            
            /*Mise en place des données*/
            numInput.Text = Convert.ToString(numSeance);
            jourSeance.Text = jour;

            //L'actualisation de la liste d'horaire ce fait par le changement du jours grace au SelectedIndexChanged

            niveau.Text = Convert.ToString(niveauCours);
            capacite.Text = Convert.ToString(capaciteCours);


            label3.Text = "Modification d'un cours";

            button2.Hide();//Ajout
            button1.Show();//Modification


        }


        





        private void jourSeance_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine("Jour seance : " + jourSeance.Text);
            List<tranchesHoraires> listeTranchesDisponible = null;
            string jourSelect = jourSeance.Text;
            listeTranchesDisponible = monManager.recuperationHoraireDiponible(idProf, jourSelect);


            trancheListe.DataSource = null;
            trancheListe.DataSource = listeTranchesDisponible;
            trancheListe.DisplayMember = "Description";
            
        }







        private void button1_Click(object sender, EventArgs e)
        {

            int numSeance = Convert.ToInt32(numInput.Text);
            string jourModif = jourSeance.Text;
            string trancheModif = trancheListe.Text;
            int niveauModif = Convert.ToInt32(niveau.Text);
            int capaciteModif = Convert.ToInt32(capacite.Text);

            monManager.modificationCours(numSeance, idProf, jourModif, trancheModif, niveauModif, capaciteModif) ;

            //Mise à jour de la liste
            listeCours cours = (listeCours)Application.OpenForms["listeCours"];
            cours.reactualisation();

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int numSeance = Convert.ToInt32(numInput.Text);
            string jourModif = jourSeance.Text;
            string trancheModif = trancheListe.Text;
            int niveauModif = Convert.ToInt32(niveau.Text);
            int capaciteModif = Convert.ToInt32(capacite.Text);

            monManager.ajoutCours(numSeance, idProf, jourModif, trancheModif, niveauModif, capaciteModif);

            //Mise à jour de la liste
            listeCours cours = (listeCours)Application.OpenForms["listeCours"];
            cours.reactualisation();

            this.Close();

        }

    }
}
