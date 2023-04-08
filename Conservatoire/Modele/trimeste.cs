using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class trimeste
    {


        private int idEleve;
        private string libelle;
        private string datePaiement;
        private int paye;

        private string dateFinTrimestre;




        public trimeste(int unIdEleve, string unLibelle, string uneDatePaiement, int unEtat)
        {

            this.idEleve = unIdEleve;
            this.libelle = unLibelle;
            this.datePaiement = uneDatePaiement;
            this.paye = unEtat;
        }


        //Surcharge du constructeur pour la récupération des trimestres
        public trimeste(string libelle, string dateFinTrimestre, int unEtat)
        {

            this.libelle = libelle;
            this.dateFinTrimestre = dateFinTrimestre;
            this.paye = unEtat;

        }



        public int IdEleve { get => idEleve; set => idEleve = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int Paye { get => paye; set => paye = value; }

        public string DateFinTrimestre { get => dateFinTrimestre; set => dateFinTrimestre = value; }




        public override string ToString()
        {
            if(this.dateFinTrimestre != null && this.dateFinTrimestre != "")
            {
                return (this.libelle + " non payé ! Date de fin : " + this.dateFinTrimestre);
                //return (this.libelle + " - " + this.dateFinTrimestre + " - 0");
            }
            else
            {
                return (this.libelle + " payé le  " + this.datePaiement);
                //return (this.idEleve + " - " + this.libelle + " - " + this.datePaiement + " - " + this.Paye);
            }
        }


    }
}
