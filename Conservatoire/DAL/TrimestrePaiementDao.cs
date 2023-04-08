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
    public class TrimestrePaiementDao
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";


        private static Connexion maConnexionSql;


        private static MySqlCommand Ocom;



        //Recup des trimestres
        public static List<trimeste> recuperationEtatPaiment(int idEleve)
        {

            List<trimeste> lt = new List<trimeste>();


            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);



                string queryString = "SELECT * FROM trim";



                Ocom = maConnexionSql.reqExec(queryString);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();

                trimeste T;

                while (reader.Read())
                {

                    string libelle = (string)reader.GetValue(0);
                    string dateFin = (string)reader.GetValue(1);

                    //Instanciation d'un Emplye
                    T = new trimeste(libelle, dateFin, 0);

                    // Ajout de cet employe à la liste 
                    lt.Add(T);



                }



                reader.Close();

                maConnexionSql.closeConnection();



                return (lt);


            }

            catch (Exception emp)
            {

                throw (emp);


            }

            return (lt);


        }






        //cheking Paiement
        public static bool CheckingPaiment(int idEleve, string libelle)
        {

            List<trimeste> lt = new List<trimeste>();

            bool result = false;

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);



                string queryString = "SELECT COUNT(*) FROM payer where IDELEVE = @idEleve AND LIBELLE = @libelle";


                Ocom = maConnexionSql.reqExec(queryString);
                Ocom.Parameters.AddWithValue("@idEleve", idEleve);
                Ocom.Parameters.AddWithValue("@libelle", libelle);



                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {

                    if ((Int64)reader.GetValue(0) == 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }


                }



                reader.Close();

                maConnexionSql.closeConnection();



                return (result);


            }

            catch (Exception emp)
            {

                throw (emp);


            }

            return (result);


        }




        //cheking Paiement
        public static trimeste RecuperationDetailsPaiement(int idEleve, string libelle)
        {


            trimeste detailsTrimestreEleve;
            trimeste Trim = new trimeste(0, "", "", 0);


            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);



                string queryString = "SELECT * FROM payer where IDELEVE = @idEleve AND LIBELLE = @libelle";


                Ocom = maConnexionSql.reqExec(queryString);
                Ocom.Parameters.AddWithValue("@idEleve", idEleve);
                Ocom.Parameters.AddWithValue("@libelle", libelle);



                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();



                while (reader.Read())
                {

                    int idElevePaiement = (int)reader.GetValue(0);
                    string libellePaiment = (string)reader.GetValue(1);
                    string datePaiement = (string)reader.GetValue(2);
                    int etatPaiement = (int)reader.GetValue(3);


                    Trim = new trimeste(idElevePaiement, libellePaiment, datePaiement, etatPaiement);


                }



                reader.Close();

                maConnexionSql.closeConnection();


                return (Trim);


            }

            catch (Exception emp)
            {

                throw (emp);


            }

            return (Trim);


        }



        //ajout de la confirmation de paiement
        public static void confirmationPaiement(int idEleve, string libelle)
        {



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                DateTime todayDate = DateTime.Today;

                string queryString = "INSERT INTO payer(IDELEVE, LIBELLE, DATEPAIEMENT, PAYE) " +
                    "VALUES ('" + idEleve + "','" + libelle + "','" + todayDate.ToString("d") + "','" + 1 + "')";


                Ocom = maConnexionSql.reqExec(queryString);


                maConnexionSql.openConnection();
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
