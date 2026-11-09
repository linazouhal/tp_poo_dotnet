using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{

    public class Formateur : Employe
    {
        private string specialite;
        private string codeEmploiTemps;
        private Salle salle;

        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }

        public string CodeEmploiTemps
        {
            get { return codeEmploiTemps; }
            set { codeEmploiTemps = value; }
        }

        public Salle SalleAffectee
        {
            get { return salle; }
            set { salle = value; }
        }

        public Formateur(int matricule, string nom, string prenom,
                         DateTime dateNaissance, DateTime dateEmbauche,
                         double salaire, double heureSupplementaire,
                         string specialite, string codeEmploiTemps,
                         Salle salle)
            : base(matricule, nom, prenom, dateNaissance,
                   dateEmbauche, salaire, heureSupplementaire)
        {
            this.specialite = specialite;
            this.codeEmploiTemps = codeEmploiTemps;
            this.salle = salle;
        }
    }

}
