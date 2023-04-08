using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class tranchesHoraires
    {

        private string tranches;


        public tranchesHoraires(string unLibelle)
        {

            this.tranches = unLibelle;

        }

        public override string ToString()
        {

            return (this.tranches);
        }

    }
}
