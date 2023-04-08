using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Prof
    {

        private int num;
        private string nom;
        private string prenom;
        private int telephone;
        private string mail;
        private string adresse;
        private string instrument;
        private float salaire;
    


        public Prof(int num, string nom, string prenom, int telephone, string mail, string adresse,string instrument, float salaire)
        {

            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.mail = mail;
            this.adresse = adresse;
            this.instrument = instrument;
            this.salaire = salaire;

        }

        public int Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Instrument { get => instrument; set => instrument = value; }
        public float Salaire { get => salaire; set => salaire = value; }



        public override string ToString()

        {

            return (this.prenom + " " + this.nom + ". Informations personnelles : " + this.mail + " - " + this.telephone + ". Adresse " + this.adresse + ". Professeur de " + this.instrument + ". Salaire  de " + this.salaire + " €");
        }


    }
}
