using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Conservatoire.Modele;

namespace Conservatoire.DAL
{
    public class InstrumentDao
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";


        private static Connexion maConnexionSql;


        private static MySqlCommand Ocom;

    }
}
