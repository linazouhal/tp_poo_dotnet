using System.Collections;

namespace TP4_Hashtable
{
    
    class Personne : IComparable
    {
        public string CIN { get; set; } = "";
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";

        public Personne() { }

        public Personne(string c, string n, string pr)
        {
            CIN = c;
            Nom = n;
            Prenom = pr;
        }

        public override string ToString()
        {
            return CIN + "\t" + Nom + "\t" + Prenom;
        }

     
        public int CompareTo(object? obj)
        {
            if (obj is Personne p)
                return this.Nom.CompareTo(p.Nom);
            else
                throw new ArgumentException("object not a person");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exemple1();
            Exemple2();

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }

        static void Exemple1()
        {
            Console.WriteLine("===== Exemple 1 =====");
            Hashtable t = new Hashtable();

            t.Add("A1", "ali");
            t.Add("A2", "yassine");
            t.Add("A3", "hamza");
            t.Add("A4", "salma");

            Console.WriteLine(t["A2"]);


            foreach (DictionaryEntry d in t)
            {
                Console.WriteLine(d.Key + "\t" + d.Value);
            }

      
            try
            {
                t.Add("A2", "sofia"); 
            }
            catch
            {
                Console.WriteLine("un element existe deja avec cette cle");
            }

          
            t["A3"] = "hind";
            Console.WriteLine("la valeur associee a la cle A3 est:" + t["A3"]);
            t["A6"] = "hicham";
            Console.WriteLine("la valeur associee a la cle A6 est:" + t["A6"]);

            if (t.Contains("A5") == false)
            {
                t.Add("A5", "anas");
            }
            else Console.WriteLine("cle deja existante");

            if (t.ContainsValue("anas") == true) Console.WriteLine("valeur existante");

            Console.WriteLine("--- Cles ---");
            foreach (string s in t.Keys)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--- Valeurs ---");
            foreach (string s in t.Values)
            {
                Console.WriteLine(s);
            }

            t.Remove("A1");

            Console.WriteLine("--- Apres Remove(\"A1\") ---");
            foreach (DictionaryEntry d in t)
            {
                Console.WriteLine(d.Key + "\t" + d.Value);
            }
            Console.WriteLine("Count : " + t.Count);
        }

        static void Exemple2()
        {
            Console.WriteLine("\n\n===== Exemple 2 =====");
            Hashtable t = new Hashtable();
            Personne p1 = new Personne("jc2131", "alami", "ahmed");
            Personne p2 = new Personne("ac1267", "alaoui", "yassine");
            Personne p3 = new Personne("bd2345", "chaaibi", "salma");

            t.Add(p1.CIN, p1);
            t.Add(p2.CIN, p2);
            t.Add(p3.CIN, p3);
            foreach (DictionaryEntry d in t)
            {
                Console.WriteLine(d.Value);
            }

            t.Remove(p1.CIN);
            Console.WriteLine("**********Suppression******");
            foreach (Personne p in t.Values)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("donner le nom");
            string? nom = Console.ReadLine();
            bool trouve = false;
            foreach (Personne p in t.Values)
            {
                if (p.Nom == nom)
                {
                    Console.WriteLine(p.ToString());
                    trouve = true;
                }
            }
            if (!trouve) Console.WriteLine("aucune personne avec ce nom");

      
            Console.WriteLine("**********Liste triee par nom******");
            List<Personne> l = new List<Personne>();
            foreach (Personne p in t.Values) l.Add(p);
            l.Sort();
            foreach (Personne p in l) Console.WriteLine(p.ToString());
        }
    }
}