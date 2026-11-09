using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Salarie
    {
        protected int matricule;
        protected string nom;
        protected string prenom;
        protected double salaire;
        protected double tauxCS;

        public Salarie(int matricule,string nom,string prenom,double salaire,double tauxCS){
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
            this.tauxCS = tauxCS;
        }
        public Salarie(){
            matricule = 0;
            nom = "";
            prenom = "";
            salaire = 0;
            tauxCS = 0;
        }

        public Salarie(Salarie s)
        {
            this.matricule= s.matricule;
            this.nom = s.nom;
            this.prenom = s.prenom;
            this.salaire= s.salaire;
            this.tauxCS= s.tauxCS;
        }

        public int GetMatricule()
        {
            return matricule;
        }

        public void SetMatricule(int matricule)
        {
            this.matricule=matricule;
        }

        public string GetNom()
        {
            return nom;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public double GetSalaire()
        {
            return salaire;
        }

        public void SetSalaire(double salaire)
        {
            this.salaire = salaire;
        }

        public double GetTauxCS()
        {
            return tauxCS;
        }

        public void SetTauxCS(double tauxCS)
        {
            this.tauxCS = tauxCS;
        }

        public void affichage()
        {
            Console.WriteLine("Matricule : " + this.matricule);
            Console.WriteLine("Nom : "+this.nom);
            Console.WriteLine("Prenom : "+this.prenom);
            Console.WriteLine("Salaire : "+this.salaire);
            Console.WriteLine("TauxCs : "+this.tauxCS);
        }

        public virtual double CalculerSalaireNet()
        {
            return this.salaire - (this.salaire * this.tauxCS);
        }

        public override bool Equals(object? obj)
        {
            if(obj is Salarie s)
            {
                return this.matricule==s.matricule;
            }
            return false;
        }
        public override string ToString()
        {
            return this.matricule+","+this.nom;
        }
        public override int GetHashCode()
        {
            return matricule.GetHashCode();
        }
    }
}
