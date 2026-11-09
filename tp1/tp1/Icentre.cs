using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tp1
{

public interface Icentre
{
}

public interface IPersonne : Icentre
{
    int CalculerAge(DateTime dateCourante);
    string ToString();
}

public interface IEmploye : Icentre
{
    double CalculTotalSalaire(double remHeure);
}

public interface ISalle : Icentre
{
    bool Equals(Salle s);
}

}