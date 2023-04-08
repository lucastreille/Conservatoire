using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Conservatoire.Modele;


namespace Conservatoire.DAL
{
    public class adminDao
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";


        private static Connexion maConnexionSql;


        private static MySqlCommand Ocom;


        //Connexion administrateur
        public static bool connexionAdmin(string mailAdmin, string mdpAdmin)
        {

            bool etatConnexion = false;


            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                string queryString = "SELECT COUNT(*) FROM administrateur WHERE mail = @mailAdmin AND mdp = @mdpAdmin";

                Ocom = maConnexionSql.reqExec(queryString);
                Ocom.Parameters.AddWithValue("@mailAdmin", mailAdmin);
                Ocom.Parameters.AddWithValue("@mdpAdmin", mdpAdmin);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();



                while (reader.Read())
                {

                    if ((Int64)reader.GetValue(0) == 0)
                    {
                        etatConnexion = false;

                    }
                    else
                    {
                        etatConnexion = true;
                    }

                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (etatConnexion);


            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }


    }
}
