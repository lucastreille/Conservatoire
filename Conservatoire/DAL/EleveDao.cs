using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Conservatoire.Modele;

namespace Conservatoire.DAL
{
    public class EleveDao
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";


        private static Connexion maConnexionSql;


        private static MySqlCommand Ocom;


        // Récupération de la liste des Eleve
        public static List<Eleve> getListEleve(int idCours)
        {

            List<Eleve> le = new List<Eleve>();



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT P.ID, P.NOM, P.PRENOM, P.TEL, P.MAIL, P.ADRESSE FROM inscription I INNER JOIN personne P ON I.IDELEVE = P.ID WHERE I.NUMSEANCE = " + idCours);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve e;




                while (reader.Read())
                {
                    //Recupération élève
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    int telephone = (int)reader.GetValue(3);
                    string mail = (string)reader.GetValue(4);
                    string adresse = (string)reader.GetValue(5);



                    //Instanciation d'un Emplye
                    e = new Eleve(id, nom, prenom, telephone, mail, adresse);

                    // Ajout de cet employe à la liste 
                    le.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (le);


            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }



        //Recup liste élève
        public static List<instrument> recupListeInstrument()
        {

            List<instrument> li = new List<instrument>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM instrument");


                MySqlDataReader reader = Ocom.ExecuteReader();

                instrument e;


                while (reader.Read())
                {

                    string instrument = (string)reader.GetValue(0);
                    Console.WriteLine((string)reader.GetValue(0));


                    //Instanciation d'un Emplye
                    e = new instrument(instrument);

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

        }















    }
}
