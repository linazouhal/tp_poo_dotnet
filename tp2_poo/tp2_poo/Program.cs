using System.Collections;

namespace tp2_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercice1_Ajout();
            Exercice2_Insertion();
            Exercice3_Suppression();
            Exercice4_AutresManipulations();
            Exercice5_CapaciteEtTri();

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }

        static void Afficher(string titre, ArrayList liste)
        {
            Console.WriteLine("--- " + titre + " ---");
            for (int i = 0; i < liste.Count; i++)
                Console.WriteLine(liste[i]);
        }

      
        static void Exercice1_Ajout()
        {
            Console.WriteLine("\n===== Exercice 1 : Add / AddRange =====");
            ArrayList liste = new ArrayList();
            liste.Add("lamiae");
            string[] noms = new string[] { "ali", "sami", "Paul" };
            liste.AddRange(noms);
            Afficher("Liste", liste);  
        }

        static void Exercice2_Insertion()
        {
            Console.WriteLine("\n===== Exercice 2 : Insert / InsertRange / indexeur =====");
            ArrayList liste = new ArrayList();
            liste.Add("lamiae");
            string[] noms = new string[] { "ali", "sami", "Paul" };

            liste.InsertRange(0, noms);    
            liste.Insert(2, "yassine");     
            foreach (string s in liste) Console.WriteLine(s);

            liste[1] = "badr";             
            Afficher("Apres remplacement de l'index 1 par badr", liste);

            try
            {
                liste.Insert(10, "erreur");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception : " + ex.GetType().Name);
            }
        }

        static void Exercice3_Suppression()
        {
            Console.WriteLine("\n===== Exercice 3 : Remove / RemoveAt / RemoveRange =====");
            ArrayList liste = new ArrayList();
            string[] noms = new string[] { "badr", "sami", "Paul", "lamiae", "yassine", "salma" };
            liste.AddRange(noms);

            liste.Remove("sami");    
            liste.RemoveAt(0);      
            for (int i = 0; i < liste.Count; i++)
                Console.WriteLine(liste[i].ToString());

            liste.RemoveRange(0, 2); 
            Console.WriteLine("***************liste finale************");
            for (int i = 0; i < liste.Count; i++)
                Console.WriteLine(liste[i].ToString());
        }

         
        static void Exercice4_AutresManipulations()
        {
            Console.WriteLine("\n===== Exercice 4 : IndexOf / Contains / Reverse =====");
            ArrayList liste = new ArrayList();
            string[] noms = new string[] { "badr", "sami", "Paul", "lamiae", "yassine", "salma" };
            liste.AddRange(noms);

            Console.WriteLine(liste.IndexOf("yassine"));
            Console.WriteLine(liste.Contains("Paul"));     

            liste.Reverse();
            Afficher("Apres Reverse", liste);            
        }

     
        static void Exercice5_CapaciteEtTri()
        {
            Console.WriteLine("\n===== Exercice 5 : Sort / Capacity / TrimToSize / Clear =====");
            ArrayList liste = new ArrayList();
            Console.WriteLine("Capacity au depart : " + liste.Capacity + " (Count = " + liste.Count + ")");

            liste.AddRange(new string[] { "badr", "sami", "Paul", "lamiae", "yassine", "salma" });
            Console.WriteLine("Apres ajout : Capacity = " + liste.Capacity + ", Count = " + liste.Count);

            liste.Sort();
            Afficher("Apres Sort", liste);

            liste.Remove("badr");
            liste.TrimToSize();
            Console.WriteLine("Apres TrimToSize : Capacity = " + liste.Capacity + ", Count = " + liste.Count);

            liste.Clear();
            Console.WriteLine("Apres Clear : Count = " + liste.Count);
        }
    }
}
