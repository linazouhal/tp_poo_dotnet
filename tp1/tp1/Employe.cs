using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{

    public class Employe : Personne, IEmploye
    {
        private DateTime dateEmbauche;
        private double salaire;
        private double heureSupplementaire;

        public DateTime DateEmbauche
        {
            get { return dateEmbauche; }
            set { dateEmbauche = value; }
        }

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public double HeureSupplementaire
        {
            get { return heureSupplementaire; }
            set { heureSupplementaire = value; }
        }

        public Employe(int matricule, string nom, string prenom,
                       DateTime dateNaissance, DateTime dateEmbauche,
                       double salaire, double heureSupplementaire)
            : base(matricule, nom, prenom, dateNaissance)
        {
            this.dateEmbauche = dateEmbauche;
            this.salaire = salaire;
            this.heureSupplementaire = heureSupplementaire;
        }

        public double CalculTotalSalaire(double remHeure)
        {
            return salaire + remHeure * heureSupplementaire;
        }
    }

}
