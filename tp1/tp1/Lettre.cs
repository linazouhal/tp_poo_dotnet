using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Lettre : ObjetPostal
    {
        private bool urgente;

        public Lettre(string nomDestinataire, string adresse,int codePostal, string ville, bool recommande, bool urgente)
            : base(nomDestinataire, adresse, codePostal, ville, recommande) {

            this.urgente = urgente;
        }

        public override double Prix(){
            double prix = 0.53;
            if (recommande)
            {
                prix += 1.5;
            }

            if (urgente)
            {
                prix += 0.6;
            }
            return prix;
        }
    }
}
