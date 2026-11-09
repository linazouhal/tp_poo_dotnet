using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Colis : ObjetPostal
    {
        private double poids;

        public Colis(string nomDestinataire, string adresse, int codePostal, string ville,bool recommande, double poids)
            : base(nomDestinataire, adresse, codePostal, ville, recommande)
        {
            this.poids = poids;
        }
        public override double Prix()
        {
            double prix = (poids / 100.0) * 0.8;
            if (recommande)
            {
                prix += 3.0;
            }

            return prix;
        }
    }
}
