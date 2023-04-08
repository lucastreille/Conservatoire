using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Cours
    {

        private int numseance;
        private int idProf;
        private string jour;
        private string tranche;
        private int niveau;
        private int capacite;
        private string nom;
        private string prenom;
        private int telephone;
        private string mail;
        private string adresse;



        public Cours(int numseance, int idProf, string jour, string tranche, int niveau, int capacite, string nom, string prenom, int telephone, string mail, string adresse)
        {

            this.Numseance = numseance;
            this.idProf = idProf;
            this.jour = jour;
            this.tranche = tranche;
            this.niveau = niveau;
            this.capacite = capacite;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.mail = mail;
            this.adresse = adresse;

        }

        public int Numseance { get => numseance; set => numseance = value; }

        public int IdProf { get => idProf; set => idProf = value; }

        public string Jour { get => jour; set => jour = value; }
        public string Tranche { get => tranche; set => tranche = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public int Capacite { get => capacite; set => capacite = value; }




        public override string ToString()

        {

            return ("Séance " + this.Numseance + " prévue le " + this.jour + " de " + this.tranche + ". Niveau : " + this.niveau + " avec une capacité de " + this.capacite + " personnes");
        }


    }
}
