using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Eleve
    {

        private int num;
        private string nom;
        private string prenom;
        private int telephone;
        private string mail;
        private string adresse;
        



        public Eleve(int num, string nom, string prenom, int telephone, string mail, string adresse)
        {

            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.mail = mail;
            this.adresse = adresse;
         
        }

        public int Num { get => num; set => num = value; }




        public override string ToString()

        {

            return (this.prenom + "  " + this.nom + ". Information personnelles : " + this.mail + " - " + this.telephone + ". Adresse : " + this.adresse);
        }


    }
}
