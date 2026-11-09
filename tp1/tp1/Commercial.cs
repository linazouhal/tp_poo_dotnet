using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Commercial:Salarie
    {
        private double chiffreAffaire;
        private double pourcentageCommission;
        public Commercial(int matricule, string nom, string prenom, double salaire, double tauxCS, double chiffreAffaire, double pourcentageCommission)
            :base(matricule,nom,prenom,salaire,tauxCS) { 
        this.chiffreAffaire = chiffreAffaire;
            this.pourcentageCommission = pourcentageCommission;
        }

        public Commercial():base() {
            this.chiffreAffaire = 0;
            this.pourcentageCommission=0;
        }
        public double getChiffreAffaire()
        {
            return this.chiffreAffaire;
        }

        public double setChiffreAffaire(double chiffreAffaire)
        {
            return this.chiffreAffaire= chiffreAffaire;
        }

        public double getCommission() {  return this.pourcentageCommission;}

        public double setPourcentageCommission(double pourcentageCommission)
        {
            return this.pourcentageCommission=pourcentageCommission;
        }

        public override double CalculerSalaireNet()
        {
             return base.CalculerSalaireNet()+(this.chiffreAffaire*this.pourcentageCommission);
        }

        public override bool Equals(object? obj)
        {
            if(obj is Commercial c )
            {
                return this.matricule==c.matricule&& this.chiffreAffaire==c.chiffreAffaire;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString()+","+ this.chiffreAffaire+","+this.pourcentageCommission;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(matricule, chiffreAffaire);
        }
    }
}
