using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Conservatoire.Modele;

namespace Conservatoire.DAL
{
    public class ProfDao
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";


        private static Connexion maConnexionSql;


        private static MySqlCommand Ocom;



        // Récupération de la liste des Profs
        public static List<Prof> getListProf()
        {

            List<Prof> lc = new List<Prof>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM prof Pr INNER JOIN personne P ON Pr.IDPROF = P.ID");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Prof e;




                while (reader.Read())
                {

                    int numero = (int)reader.GetValue(0);
                    string instrument = (string)reader.GetValue(1);
                    float salaire = (float)reader.GetValue(2);

                    string nom = (string)reader.GetValue(4);
                    string prenom = (string)reader.GetValue(5);
                    int telephone = (int)reader.GetValue(6);
                    string mail = (string)reader.GetValue(7);
                    string adresse = (string)reader.GetValue(8);



                    //Instanciation d'un Emplye
                    e = new Prof(numero, nom, prenom, telephone, mail, adresse, instrument, salaire);

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



        //insertion d'une personne
        public static void ajoutPersonne(string prenom, string nom, string mail, int telephone, string adresse)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO personne(NOM, PRENOM, MAIL, TEL, ADRESSE, IMAGE) " +
                    "VALUES ('" + nom + "','" + prenom + "','" + mail + "','" + telephone + "','" + adresse + "','')");


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }



        //Recup dernier ID
        public static int recuperationDernierId()
        {

            int derniereId = 0;


            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT ID FROM personne WHERE ID = (SELECT MAX(ID) FROM personne)");


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


        //insertion d'un professeur
        public static void ajoutProf(int idPersonne, string instrument, int salaire)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO prof(IDPROF, INSTRUMENT, SALAIRE) " +
                    "VALUES ('" + idPersonne + "','" + instrument + "','" + salaire + "')");


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }








        //modification d'une personne
        public static void modificationPersonne(int idProfModification, string prenom, string nom, string mail, int telephone, string adresse)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("UPDATE personne SET NOM = '" + nom + "', PRENOM = '" + prenom + "', MAIL = '" + mail + "', TEL = '" + telephone + "', ADRESSE = '" + adresse + "' WHERE ID=" + idProfModification);


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }




        //modification d'un prof
        public static void modificationProf(int idProfModification, string instrument, int salaire)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("UPDATE prof SET INSTRUMENT = '" + instrument + "', SALAIRE = '" + salaire + "' WHERE IDPROF=" + idProfModification);


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
        public static bool verification(int idProf)
        {



            try
            {

                bool etatSupression = false;

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT COUNT(*) FROM seance WHERE IDPROF=" + idProf);


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
        public static void supressionProf(int idProf)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE FROM prof WHERE IDPROF=" + idProf);


                MySqlDataReader reader = Ocom.ExecuteReader();


                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }


        //supression d'une personne
        public static void supressionPersonne(int idProf)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE FROM personne WHERE ID=" + idProf);


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
