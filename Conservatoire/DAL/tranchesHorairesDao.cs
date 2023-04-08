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
    public class tranchesHorairesDao
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";


        private static Connexion maConnexionSql;


        private static MySqlCommand Ocom;







        //Recup liste des tranches horaires --------------------------------------
        public static List<tranchesHoraires> recuperationHoraires()
        {


            List<tranchesHoraires> li = new List<tranchesHoraires>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM heure");


                MySqlDataReader reader = Ocom.ExecuteReader();

                tranchesHoraires e;


                while (reader.Read())
                {

                    string tranche = (string)reader.GetValue(0);


                    //Instanciation d'un Emplye
                    e = new tranchesHoraires(tranche);

                    // Ajout de cet employe à la liste 
                    li.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (li);


            }

            catch (Exception emp)
            {

                throw (emp);

            }

            return (li);


        }







        //Recup liste des tranches horaires disponibles
        public static bool recuperationHoraireDiponible(int idProf, string jour, string heureDepart, string heureFin)
        {

            //Console.WriteLine("jours choisi : " + jour + " id prof : " + idProf + " heure départ : " + heureDepart + " heure fin : " + heureFin);

            bool etatTrancheHoraire = false;

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                string queryString = "SELECT COUNT(*) " +
                                        "FROM seance S " +
                                        "WHERE S.JOUR = @jourselect " +
                                        "AND S.IDPROF = @idProf " +
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
                Ocom.Parameters.AddWithValue("@idProf", idProf);
                Ocom.Parameters.AddWithValue("@heureDepart", heureDepart);
                Ocom.Parameters.AddWithValue("@heureFin", heureFin);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {




                    if ((Int64)reader.GetValue(0) == 0)
                    {
                        etatTrancheHoraire = false;

                    }
                    else
                    {
                        etatTrancheHoraire = true;
                    }




                }



                reader.Close();

                maConnexionSql.closeConnection();



                return (etatTrancheHoraire);


            }

            catch (Exception emp)
            {

                throw (emp);


            }

            return (etatTrancheHoraire);


        }













    }
}
