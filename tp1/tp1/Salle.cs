using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{

    public class Salle : ISalle
    {
        private int numero;
        private string type;
        private int nombreChaise;
        private int nombreTable;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int NombreChaise
        {
            get { return nombreChaise; }
            set { nombreChaise = value; }
        }

        public int NombreTable
        {
            get { return nombreTable; }
            set { nombreTable = value; }
        }

        public Salle(int numero, string type,
                     int nombreChaise, int nombreTable)
        {
            this.numero = numero;
            this.type = type;
            this.nombreChaise = nombreChaise;
            this.nombreTable = nombreTable;
        }

        public bool Equals(Salle s)
        {
            if (s == null)
            {
                return false;
            }

            return this.nombreTable == s.nombreTable
                   && this.type == s.type;
        }
    }

}
