using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public abstract class Personne : IPersonne
    {
        private int matricule;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public Personne(int matricule, string nom, string prenom,
                        DateTime dateNaissance)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public int CalculerAge(DateTime dateCourante)
        {
            int age = dateCourante.Year - dateNaissance.Year;

            if (dateNaissance.Date > dateCourante.AddYears(-age).Date)
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            return nom + "\t" + prenom + ":" + matricule;
        }
    }
}
