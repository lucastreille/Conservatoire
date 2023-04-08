using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Conservatoire.Modele;

namespace Conservatoire.DAL
{
    public class CoursDao
    {

          // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";


        private static Connexion maConnexionSql;


        private static MySqlCommand Ocom;


        // Récupération de la liste des Cours
        public static List<Cours> getListCours(int idProf)
        {

            List<Cours> lc = new List<Cours>();



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM seance S INNER JOIN personne P ON S.IDPROF = P.ID WHERE S.IDPROF = " + idProf);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Cours e;




                while (reader.Read())
                {
                    //idProf envoyé dans la requête
                    int numseance = (int)reader.GetValue(1);
                    string tranche = (string)reader.GetValue(2);
                    string jour = (string)reader.GetValue(3);
                    int niveau = (int)reader.GetValue(4);
                    int capacite = (int)reader.GetValue(5);

                    string nom = (string)reader.GetValue(7);
                    string prenom = (string)reader.GetValue(8);
                    int telephone = (int)reader.GetValue(9);
                    string mail = (string)reader.GetValue(10);
                    string adresse = (string)reader.GetValue(11);



                    //Instanciation d'un Emplye
                    e = new Cours(numseance, idProf, jour, tranche, niveau, capacite, nom, prenom, telephone, mail, adresse);

                    // Ajout de cet employe à la liste 
                    lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }



        //modification d'un cours
        public static void modificationCours(int numSeance, int idProf, string jourModif, string trancheModif, int niveauModif, int capaciteModif)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("UPDATE seance SET IDPROF = '" + idProf + "', NUMSEANCE = '" + numSeance + "', TRANCHE = '" + trancheModif + "', JOUR = '" + jourModif + "', NIVEAU = '" + niveauModif + "', CAPACITE = '" + capaciteModif + "' WHERE NUMSEANCE=" + numSeance);


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();


            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }




        //Recup dernier ID de seance
        public static int recuperationDernierSeance()
        {

            int derniereId = 0;


            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT NUMSEANCE FROM seance WHERE NUMSEANCE = (SELECT MAX(NUMSEANCE) FROM seance)");


                MySqlDataReader reader = Ocom.ExecuteReader();

                instrument e;


                while (reader.Read())
                {

                    derniereId = (int)reader.GetValue(0);

                }



                reader.Close();

                maConnexionSql.closeConnection();


                return (derniereId);


            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }



        //insertion d'un cours
        public static void ajoutCours(int numSeance, int idProf, string jourModif, string trancheModif, int niveauModif, int capaciteModif)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO seance(IDPROF, NUMSEANCE, TRANCHE, JOUR, NIVEAU, CAPACITE) " +
                    "VALUES ('" + idProf + "','" + numSeance + "','" + trancheModif + "','" + jourModif + "','" + niveauModif + "','" + capaciteModif + "')");


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }







        //Verification pour supression d'une personne
        public static bool verificationCours(int numSeance)
        {



            try
            {

                bool etatSupression = false;

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT COUNT(*) FROM inscription WHERE NUMSEANCE=" + numSeance);


                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {

                    if ((Int64)reader.GetValue(0) == 0)
                    {
                        etatSupression = true;
                    }
                    else
                    {
                        etatSupression = false;
                    }

                }



                reader.Close();

                maConnexionSql.closeConnection();

                return etatSupression;



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }




        //supression d'un prof
        public static void supressionCours(int numSeance)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE FROM seance WHERE NUMSEANCE=" + numSeance);


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }






        //Recup liste des élèves exclus 
        public static List<Eleve> recupListeEleveExclu(string jour, string heureDepart, string heureFin)
        {

            List<Eleve> li = new List<Eleve>();


            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                string queryString = "SELECT ID, NOM, PRENOM, MAIL, TEL, ADRESSE " +
                                        "FROM inscription I " +
                                        "INNER JOIN seance S " +
                                        "ON I.NUMSEANCE = S.NUMSEANCE " +
                                        "INNER JOIN personne P " +
                                        "ON I.IDELEVE = P.ID " +
                                        "WHERE S.JOUR = @jourselect " +
                                        "AND(" +

                                            "((SELECT SUBSTRING_INDEX(S.TRANCHE, 'h', 1)) <= (SELECT CAST(@heureDepart AS INT))" +
                                                "AND(SELECT SUBSTRING_INDEX(SUBSTRING_INDEX(S.TRANCHE, 'h', 2), '-', -1)) <= (SELECT CAST(@heureFin AS INT))" +
                                                "AND(SELECT SUBSTRING_INDEX(SUBSTRING_INDEX(S.TRANCHE, 'h', 2), '-', -1)) > (SELECT CAST(@heureDepart AS INT)))" +

                                            "OR((SELECT SUBSTRING_INDEX(S.TRANCHE, 'h', 1)) >= (SELECT CAST(@heureDepart AS INT))" +
                                                    "AND(SELECT SUBSTRING_INDEX(SUBSTRING_INDEX(S.TRANCHE, 'h', 2), '-', -1)) >= (SELECT CAST(@heureFin AS INT)) " +
                                                    "AND(SELECT SUBSTRING_INDEX(S.TRANCHE, 'h', 1)) < (SELECT CAST(@heureFin AS INT)))" +

                                            "OR((SELECT SUBSTRING_INDEX(S.TRANCHE, 'h', 1)) <= (SELECT CAST(@heureDepart AS INT))" +
                                                    "AND(SELECT SUBSTRING_INDEX(SUBSTRING_INDEX(S.TRANCHE, 'h', 2), '-', -1)) >= (SELECT CAST(@heureFin AS INT)))" +

                                            "OR((SELECT SUBSTRING_INDEX(S.TRANCHE, 'h', 1)) >= (SELECT CAST(@heureDepart AS INT))" +
                                                    "AND(SELECT SUBSTRING_INDEX(SUBSTRING_INDEX(S.TRANCHE, 'h', 2), '-', -1)) <= (SELECT CAST(@heureFin AS INT)))" +

                                        ")";


                Ocom = maConnexionSql.reqExec(queryString);
                Ocom.Parameters.AddWithValue("@jourselect", jour);
                Ocom.Parameters.AddWithValue("@heureDepart", heureDepart);
                Ocom.Parameters.AddWithValue("@heureFin", heureFin);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve T;

                while (reader.Read())
                {

                    int num = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string mail = (string)reader.GetValue(3);
                    int telephone = (int)reader.GetValue(4);
                    string adresse = (string)reader.GetValue(5);


                    //Instanciation d'un Emplye
                    T = new Eleve(num, nom, prenom, telephone, mail, adresse);

                    // Ajout de cet employe à la liste 
                    li.Add(T);





                }



                reader.Close();

                maConnexionSql.closeConnection();



                return (li);


            }

            catch (Exception emp)
            {

                throw (emp);


            }

            return (li);


        }






        //Recup la liste des élèves disponibles
        public static List<Eleve> listeEleveTotal()
        {

            List<Eleve> li = new List<Eleve>();


            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);



                string queryString = "SELECT ID, NOM, PRENOM, MAIL, TEL, ADRESSE " +
                                      "FROM eleve E " +
                                      "INNER JOIN personne PR " +
                                      "ON E.IDELEVE = PR.ID ";


                Ocom = maConnexionSql.reqExec(queryString);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve T;

                while (reader.Read())
                {

                    int num = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string mail = (string)reader.GetValue(3);
                    int telephone = (int)reader.GetValue(4);
                    string adresse = (string)reader.GetValue(5);


                    //Instanciation d'un Emplye
                    T = new Eleve(num, nom, prenom, telephone, mail, adresse);

                    // Ajout de cet employe à la liste 
                    li.Add(T);

                    Console.WriteLine("Numero : " + T.Num);



                }



                reader.Close();

                maConnexionSql.closeConnection();



                return (li);


            }

            catch (Exception emp)
            {

                throw (emp);


            }

            return (li);


        }






        //insertion d'un élève à un cours
        public static void ajoutEleveSeance(int idProf, int numSeance, int idEleve)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO inscription(IDPROF, NUMSEANCE, IDELEVE, DATEINSCRIPTION) " +
                    "VALUES ('" + idProf + "','" + numSeance + "','" + idEleve + "','')");


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }




        //supression d'un eleve d'une seance
        public static void suppressionEleveSeance(int idEleve)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE FROM inscription WHERE IDELEVE=" + idEleve);


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }




















    }

}
