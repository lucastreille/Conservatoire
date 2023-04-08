using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conservatoire.controleurs;
using Conservatoire.Modele;
using Conservatoire.vues;

namespace Conservatoire.Vues
{
    public partial class gestionProf : Form
    {

        Mgr monManager = new Mgr();
        List<instrument> listeInstrument = new List<instrument>();

        string etatGestionProf = "";
        int idProfModification = 0;



        public gestionProf()
        {
            InitializeComponent();

            //Récupération et affichage liste instrument
            listeInstrument = monManager.recupListeInstrument();
            afficheInstrument();

            etatGestionProf = "ajout";

            label6.Text = "Ajouter un professeur";
            button1.Text = "Ajouter ce professeur";


        }



        //Surcharge de prof pour la modification
        public gestionProf(Prof Pr)
        {
            InitializeComponent();

            //Récupération et affichage liste instrument
            listeInstrument = monManager.recupListeInstrument();
            afficheInstrument();

            //Mise en place des données connu sur le prof

            idProfModification = Pr.Num;

            nomInput.Text = Pr.Nom;
            prenomInput.Text = Pr.Prenom;
            mailInput.Text = Pr.Mail;
            telephoneInput.Text = Convert.ToString(Pr.Telephone);
            adresseInput.Text = Pr.Adresse;

            InstrumentListe.Text = Pr.Instrument;
            salaireInput.Text = Convert.ToString(Pr.Salaire);

            etatGestionProf = "modification";

            label6.Text = "Modifier un professeur";
            button1.Text = "Modifier ce professeur";

        }






        public void afficheInstrument()
        {


            try
            {

                InstrumentListe.DataSource = null;
                InstrumentListe.DataSource = listeInstrument;
                InstrumentListe.DisplayMember = "Description";

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("nom : " + nomInput.Text);
            
            if(prenomInput.Text != "" && nomInput.Text != "" && mailInput.Text != "" && telephoneInput.Text != "" && adresseInput.Text != "" && InstrumentListe.Text != "" && salaireInput.Text != "")
            {
                if(etatGestionProf == "ajout")
                {

                    string prenom = prenomInput.Text;
                    string nom = nomInput.Text;
                    string mail = mailInput.Text;
                    int telephone = Convert.ToInt32(telephoneInput.Text);
                    string adresse = adresseInput.Text;
                    string instrument = InstrumentListe.Text;
                    int salaire = Convert.ToInt32(salaireInput.Text);


                    monManager.ajoutProf(prenom, nom, mail, telephone, adresse, instrument, salaire);

                }
                else //modification
                {

                    string prenom = prenomInput.Text;
                    string nom = nomInput.Text;
                    string mail = mailInput.Text;
                    int telephone = Convert.ToInt32(telephoneInput.Text);
                    string adresse = adresseInput.Text;
                    string instrument = InstrumentListe.Text;
                    int salaire = Convert.ToInt32(salaireInput.Text);

                    monManager.modifcationProf(idProfModification, prenom, nom, mail, telephone, adresse, instrument, salaire);

                }
               

                //Mise à jour de la liste
                listPorfesseur cours = (listPorfesseur)Application.OpenForms["listPorfesseur"];
                cours.reactualisation();

                this.Close();
            }
            else
            {
                MessageBox.Show("Certains champs ne sont pas remplis !");
            }



        }


    }
}
