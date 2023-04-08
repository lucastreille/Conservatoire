using Conservatoire.controleurs;
using Conservatoire.DAL;
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
    public partial class listeEleve : Form
    {

        private Cours Crs;
        Mgr monManager = new Mgr();

        List<Eleve> ListeEleve = new List<Eleve>();
        List<Eleve> listeEleveExclu = new List<Eleve>();

        string trancheHoraire;
        string jour;

        int idProf;
        int numSeance;

        public listeEleve(Cours unCours)
        {

            InitializeComponent();
            this.Crs = unCours;

            trancheHoraire = Crs.Tranche;
            jour = Crs.Jour;

            idProf = Crs.IdProf;
            numSeance = Crs.Numseance;

        }


        private void listeEleve_Load(object sender, EventArgs e)
        {

            int idCours = Crs.Numseance;
            ListeEleve = monManager.chargementListeEleve(idCours);


            //Controle le nombre de cours
            if (ListeEleve.Count() == 0)
            {
                Supprimer.Hide();
           
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
                listBox1.DataSource = ListeEleve;
                listBox1.DisplayMember = "Description";

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        //Ajout d'un élève à un cour
        private void Ajouter_Click(object sender, EventArgs e)
        {


            recuperationEleveDisponible();


            listeElev.Show();
            confirmationAjout.Show();

            Ajouter.Hide();
            

        }



        //Supprimer un élève d'un cours
        private void Supprimer_Click(object sender, EventArgs e)
        {

            Eleve elev = (Eleve)listBox1.SelectedItem;
            int idEleve = elev.Num;

            monManager.suppressionEleveSeance(idEleve);

            reactualisation();

        }

        private void confirmationAjout_Click(object sender, EventArgs e)
        {

            Eleve elev = (Eleve)listeElev.SelectedItem;
            int idEleve = elev.Num;

            monManager.ajoutEleveSeance(idProf, numSeance, idEleve);

            recuperationEleveDisponible();

            reactualisation();
            
            listeElev.Hide();
            confirmationAjout.Hide();

            Ajouter.Show();

        }



        //Récupération des élèves dipsonibles pour la seance séléctionner
        private void recuperationEleveDisponible()
        {

            List<Eleve> maListeEleve = new List<Eleve>();
            List<Eleve> maListeEleveDispo = new List<Eleve>();

            listeEleveExclu = monManager.recupListeEleveExclu(trancheHoraire, jour);


            maListeEleve = monManager.listeEleveTotal();



            foreach (Eleve eleveDispo in maListeEleve)
            {

                int compteur = 0;
                int numeroEleveDispo = eleveDispo.Num;//Numero de l'élève a checker

                foreach (Eleve eleveExclu in listeEleveExclu)
                {

                    int numeroEleveExclu = eleveExclu.Num;//Numero d'un élève indisponible

                    if (numeroEleveExclu == numeroEleveDispo)
                    {
                        //Eleve indisponible
                    }
                    else
                    {
                        //Eleve non trouvé compteur ++
                        compteur++;
                    }

                }


                //Si le compteur est égale au nombre d'élément de la liste cela signifi que le membre n'a pas été trouvé dans la liste d'exclusion
                if (compteur == listeEleveExclu.Count())
                {
                    maListeEleveDispo.Add(eleveDispo);
                }

            }


            //Ajout à la combo box
            listeElev.DataSource = null;
            listeElev.DataSource = maListeEleveDispo;
            listeElev.DisplayMember = "Description";

        }





        //Réactualisation après ajout ou suppression
        private void reactualisation()
        {


            int idCours = Crs.Numseance;
            ListeEleve = monManager.chargementListeEleve(idCours);


            //Remise à jour des champs visible
            listeElev.Hide();
            confirmationAjout.Hide();
            Ajouter.Show();

            if (ListeEleve.Count() == 0)
            {
                Supprimer.Hide();
                affiche();

            }
            else
            {
                Supprimer.Show();
                affiche();

            }



        }



    }
}
