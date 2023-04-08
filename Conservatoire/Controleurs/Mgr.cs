using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Conservatoire.DAL;
using Conservatoire.Modele;
using Conservatoire.vues;
using Conservatoire.Vues;


namespace Conservatoire.controleurs
{
    internal class Mgr
    {

        List<Prof> maListeProf;
        List<Cours> maListeCours;
        List<Eleve> maListeEleve;
        List<instrument> maListeInstrument;
       

        public Mgr()
        {
            //maListeProf= new List<Prof>();
        }
        

        public List<Prof> chargementEmpBD()
        {

            maListeProf = ProfDao.getListProf();


            return (maListeProf);

        }

        public List<Cours> chargementListeCours(int idProf)
        {

            maListeCours = CoursDao.getListCours(idProf);


            return (maListeCours);

        }


        public List<Eleve> chargementListeEleve(int idCours)
        {

            maListeEleve = EleveDao.getListEleve(idCours);


            return (maListeEleve);

        }


        public bool connexionAdmin(string mail, string mdp)
        {

            bool retourConnect = adminDao.connexionAdmin(mail, mdp);


            return (retourConnect);

        }


        public List<instrument> recupListeInstrument()
        {

            maListeInstrument = EleveDao.recupListeInstrument();


            return (maListeInstrument);

        }


        public void ajoutProf(string prenom, string nom, string mail, int telephone, string adresse, string instrument, int salaire)
        {


            ProfDao.ajoutPersonne(prenom, nom, mail, telephone, adresse);

            int dernierID = ProfDao.recuperationDernierId();

            ProfDao.ajoutProf(dernierID, instrument, salaire);


        }


        public void modifcationProf(int idProfModification, string prenom, string nom, string mail, int telephone, string adresse, string instrument, int salaire)
        {


            ProfDao.modificationPersonne(idProfModification, prenom, nom, mail, telephone, adresse);

            ProfDao.modificationProf(idProfModification, instrument, salaire);


        }

        public bool supressionProf(int idProf)
        {

            //Ajouter la vérification pour le fait qu'un prof puisse être affilié à un cour

            bool retourControle = ProfDao.verification(idProf);

            if(retourControle == true)
            {
                ProfDao.supressionProf(idProf);
                ProfDao.supressionPersonne(idProf);

                return retourControle;
            }
            else
            {
                return retourControle;
            }



        }







        //Gestion de la modification de séance
        public List<tranchesHoraires> recuperationHoraireDiponible(int idProf, string jour)
        {

            List<tranchesHoraires> listeTotalTrancheHoraire;
            List<tranchesHoraires> maListeTranches = new List<tranchesHoraires>();



            listeTotalTrancheHoraire = tranchesHorairesDao.recuperationHoraires();


          
            foreach (tranchesHoraires tr in listeTotalTrancheHoraire)
            {
                //Console.WriteLine(tr);


                string[] TraitementHeure = Convert.ToString(tr).Split('h');
                string heureDepart = TraitementHeure[0];

                string[] traitementHeureFin = TraitementHeure[1].Split('-');   
                string heureFin = traitementHeureFin[1];

                // Console.WriteLine(heureDepart + "et" + heureFin);


                bool etatTrancheHoraire = tranchesHorairesDao.recuperationHoraireDiponible(idProf, jour, heureDepart, heureFin);

                if(etatTrancheHoraire == false) //horaire non trouvée donc disponible
                {
                    //Console.WriteLine("Tranche autorisé : " + tr);
                    maListeTranches.Add(tr);
                }

            }


            return maListeTranches;


        }






        //modification du cours
        public void modificationCours(int numSeance, int idProf, string jourModif, string trancheModif, int niveauModif, int capaciteModif)
        {
            CoursDao.modificationCours(numSeance, idProf, jourModif, trancheModif, niveauModif, capaciteModif);
        }


        //Récupération du dernier id de seance
        public int recuperationDernierSeance()
        {
            int dernierId = CoursDao.recuperationDernierSeance();
            return dernierId;
        }

        //Ajout d'une seance
        public void ajoutCours(int numSeance, int idProf, string jourModif, string trancheModif, int niveauModif, int capaciteModif)
        {
            CoursDao.ajoutCours(numSeance, idProf, jourModif, trancheModif, niveauModif, capaciteModif);
        }



        //Suppression d'un professeur
        public bool suppressionCours(int numSeance)
        {

            //Ajouter la vérification pour le fait qu'un prof puisse être affilié à un cour

            bool retourControle = CoursDao.verificationCours(numSeance);

            if (retourControle == true)
            {
                CoursDao.supressionCours(numSeance);

                return retourControle;
            }
            else
            {
                return retourControle;
            }



        }





        //Gestion de l'ajout d'un élève
        public List<Eleve> recupListeEleveExclu(string trancheHoraire, string jour)
        {

            List<Eleve> maListeEleveExclu = new List<Eleve>();


            string[] TraitementHeure = Convert.ToString(trancheHoraire).Split('h');
            string heureDepart = TraitementHeure[0];

            string[] traitementHeureFin = TraitementHeure[1].Split('-');
            string heureFin = traitementHeureFin[1];


            //Console.WriteLine(heureDepart + "et" + heureFin);


            maListeEleveExclu = CoursDao.recupListeEleveExclu(jour, heureDepart, heureFin);


           /* foreach(Eleve eleve in maListeEleveExclu)
            {
                Console.WriteLine("Indisponible MGR : " +eleve);
            }*/


            return maListeEleveExclu;

        }



        //Récupère la liste de tout les élèves pour insertion à un cour
        public List<Eleve> listeEleveTotal()
        {

            List<Eleve> maListeEleveDispo = new List<Eleve>();

            maListeEleveDispo = CoursDao.listeEleveTotal();

            return maListeEleveDispo;

        }


        //Ajout d'un eleve à une seance
        public void ajoutEleveSeance(int idProf, int numSeance, int idEleve)
        {
            CoursDao.ajoutEleveSeance(idProf, numSeance, idEleve);
        }



        //Supression d'un eleve à une seance
        public void suppressionEleveSeance(int idEleve)
        {
            CoursDao.suppressionEleveSeance(idEleve);
        }





        //Gestion de la récupération des paiement

        public List<trimeste> recuperationEtatPaiment(int idEleve)
        {

            List<trimeste> listeTotalTrimestre = new List<trimeste>();
            List<trimeste> listeEtatPaiementTrimestre = new List<trimeste>();

            listeTotalTrimestre = TrimestrePaiementDao.recuperationEtatPaiment(idEleve);


            foreach(trimeste trim in listeTotalTrimestre)
            {
                string libelle = trim.Libelle;

                bool EtatPaiement = TrimestrePaiementDao.CheckingPaiment(idEleve, libelle);

                //Console.WriteLine("Etat : " + EtatPaiement);

                if(EtatPaiement == true)
                {

                    trimeste detailPaimentEleve = TrimestrePaiementDao.RecuperationDetailsPaiement(idEleve, libelle);

                    listeEtatPaiementTrimestre.Add(detailPaimentEleve);

                }
                else
                {
                    listeEtatPaiementTrimestre.Add(trim);
                }
                
            }



            return listeEtatPaiementTrimestre;

        }


        public void confirmationPaiement(int idEleve, string libelle)
        {
            TrimestrePaiementDao.confirmationPaiement(idEleve, libelle);
        }



    }


}
