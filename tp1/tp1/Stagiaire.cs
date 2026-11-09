using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tp1
{

    public class Stagiaire : Personne
    {
        private string cin;
        private string niveau;
        private string branche;
        private int nombreHeuresAbsence;
        private int nombreAvertissement;

        public string CIN
        {
            get { return cin; }
            set { cin = value; }
        }

        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        public string Branche
        {
            get { return branche; }
            set { branche = value; }
        }

        public int NombreHeuresAbsence
        {
            get { return nombreHeuresAbsence; }
            set { nombreHeuresAbsence = value; }
        }

        public int NombreAvertissement
        {
            get { return nombreAvertissement; }
            set { nombreAvertissement = value; }
        }

        public Stagiaire(int matricule, string nom, string prenom,
                         DateTime dateNaissance, string cin,
                         string niveau, string branche,
                         int nombreHeuresAbsence, int nombreAvertissement)
            : base(matricule, nom, prenom, dateNaissance)
        {
            this.cin = cin;
            this.niveau = niveau;
            this.branche = branche;
            this.nombreHeuresAbsence = nombreHeuresAbsence;
            this.nombreAvertissement = nombreAvertissement;
        }
    }
}
