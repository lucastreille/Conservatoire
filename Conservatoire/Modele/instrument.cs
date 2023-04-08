using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class instrument
    {

        private string libelle;


        public instrument( string unLibelle)
        {

            this.libelle = unLibelle;
            
        }

        public override string ToString()

        {

            return (this.libelle);
        }



    }
}
