using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conservatoire.controleurs;
using Conservatoire.Modele;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conservatoire.Vues
{
    public partial class listePaimentEleve : Form
    {

        Mgr monManager = new Mgr();
        List<Eleve> listeDesEleves = new List<Eleve>();
        List<trimeste> listeTrimesteEleve = new List<trimeste>();


        public listePaimentEleve()
        {
            InitializeComponent();

            listeDesEleves = monManager.listeEleveTotal();

            affichageListeEleve();


        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Eleve elev = (Eleve)listBox1.SelectedItem;
            int idEleve = elev.Num;

            listeTrimesteEleve = monManager.recuperationEtatPaiment(idEleve);

            affichageListeTrimestre();


        }







        public void affichageListeEleve()
        {

            try
            {

                listBox1.DataSource = null;
                listBox1.DataSource = listeDesEleves;
                listBox1.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        public void affichageListeTrimestre()
        {

            try
            {


                listBox2.DataSource = null;
                listBox2.DataSource = listeTrimesteEleve;
                listBox2.DisplayMember = "Description";

                /*Gestion de laffichage coloré*/
                listBox2.DrawMode = DrawMode.OwnerDrawFixed;
                listBox2.DrawItem += new DrawItemEventHandler(ListBox2_DrawItem);


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        /*Gstion de la couleur pour payé ou non payé*/
        private void ListBox2_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {

            trimeste trim = listeTrimesteEleve[e.Index];
            int etatPaiement = trim.Paye;


            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            if(etatPaiement == 0)
            {
                myBrush = Brushes.Red;
            }
            else
            {
                myBrush = Brushes.Green;
            }

            e.Graphics.DrawString(listBox2.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

        }





        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            if ((trimeste)listBox2.SelectedItem != null)
            {
                
               trimeste trim = (trimeste)listBox2.SelectedItem;
               int etatPaiement = trim.Paye;

                Console.WriteLine("Etat paiement : " + etatPaiement);

                if(etatPaiement == 0)
                {

                    string datePaiement = trim.DateFinTrimestre;

                    DateTime dateTransform = DateTime.ParseExact(datePaiement, "dd/MM/yyyy", new CultureInfo("fr-FR", true));
                    DateTime todayDate = DateTime.Today;

                    

                    if (dateTransform >= todayDate)
                    {
                        Console.WriteLine("Date OK");
                        button1.Show();
                    }
                    else
                    {
                        Console.WriteLine("Date dépassé");
                        button1.Hide();
                    }

                    

                }
                else 
                {
                    button1.Hide();
                }
               
           
            }



        }



        private void button1_Click(object sender, EventArgs e)
        {

            trimeste trim = (trimeste)listBox2.SelectedItem;
            string libelle = trim.Libelle;

            Eleve eleve = (Eleve)listBox1.SelectedItem;
            int idEleve = eleve.Num;

            Console.WriteLine(idEleve);
            Console.WriteLine(libelle);

            monManager.confirmationPaiement(idEleve, libelle);

            réactualiser();
        }


        private void réactualiser()
        {

            Eleve elev = (Eleve)listBox1.SelectedItem;
            int idEleve = elev.Num;

            listeTrimesteEleve = monManager.recuperationEtatPaiment(idEleve);

            affichageListeTrimestre();

        }

        private void listePaimentEleve_Load(object sender, EventArgs e)
        {

        }
    }
}
