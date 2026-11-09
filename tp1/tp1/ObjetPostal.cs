using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public abstract class ObjetPostal
    {
        protected string nomDestinataire;
        protected string adresse;
        protected int codePostal;
        protected string ville;
        protected bool recommande;
        public ObjetPostal(string nomDestinataire, string adresse, int codePostal, string ville, bool recommande)
        {
            this.nomDestinataire = nomDestinataire;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.recommande = recommande;
        }
        public abstract double Prix();
    }
}
