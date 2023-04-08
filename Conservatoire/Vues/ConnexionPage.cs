using Conservatoire.controleurs;
using Conservatoire.vues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Conservatoire.Vues
{
    public partial class ConnexionPage : Form
    {

        Mgr monManager = new Mgr();

        public ConnexionPage()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mail = textBox1.Text;
            string mdp = textBox2.Text;

            bool retourConnect = monManager.connexionAdmin(mail, mdp);


            if (retourConnect == true)
            { 

                this.Hide();

                //Ouverture liste Professeur
                listPorfesseur AffichageListeProfs = new listPorfesseur();
                AffichageListeProfs.ShowDialog();

                this.Close();

            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect !");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void style1_Click(object sender, EventArgs e)
        {

        }
    }
}
