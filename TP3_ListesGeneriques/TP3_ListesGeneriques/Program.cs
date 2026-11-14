namespace TP3_ListesGeneriques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExempleDuCours();
            Bonus();

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }

        static void ExempleDuCours()
        {
            List<string> noms = new List<string>();
            Console.WriteLine("\nCapacity: {0}", noms.Capacity);

            noms.Add("salwa");
            noms.Add("adil");
            noms.Add("samir");
            noms.Add("imane");
            noms.Add("issam");

            Console.WriteLine();
            foreach (string nom in noms)
            {
                Console.WriteLine(nom);
            }

            Console.WriteLine("\nCapacity: {0}", noms.Capacity);
            Console.WriteLine("Count: {0}", noms.Count);

            Console.WriteLine("\nContains(\"samir\"): {0}", noms.Contains("samir"));

            Console.WriteLine("\nInsert(2, \"jihane\")");
            noms.Insert(2, "jihane");

            Console.WriteLine();
            foreach (string nom in noms)
            {
                Console.WriteLine(nom);
            }

            Console.WriteLine("\nnoms[3]: {0}", noms[3]);

            Console.WriteLine("\nRemove(\"adil\")");
            noms.Remove("adil");

            Console.WriteLine();
            foreach (string nom in noms)
            {
                Console.WriteLine(nom);
            }

            noms.TrimExcess();
            Console.WriteLine("\nTrimExcess()");
            Console.WriteLine("Capacity: {0}", noms.Capacity);
            Console.WriteLine("Count: {0}", noms.Count);

            noms.Clear();
            Console.WriteLine("\nClear()");
            Console.WriteLine("Capacity: {0}", noms.Capacity);
            Console.WriteLine("Count: {0}", noms.Count);
        }

    
        static void Bonus()
        {
            Console.WriteLine("\n\n===== Bonus : autres methodes de List<T> =====");
            List<string> noms = new List<string>();
            noms.AddRange(new string[] { "salwa", "adil", "samir", "imane", "issam", "adil" });

            Console.WriteLine("IndexOf(\"adil\"): {0}", noms.IndexOf("adil"));          // 1
            Console.WriteLine("LastIndexOf(\"adil\"): {0}", noms.LastIndexOf("adil"));  // 5

            noms.InsertRange(0, new string[] { "zineb", "omar" });
            Console.WriteLine("\nApres InsertRange(0, ...) :");
            noms.ForEach(n => Console.WriteLine(n));

            noms.Sort();
            Console.WriteLine("\nApres Sort() :");
            noms.ForEach(n => Console.WriteLine(n));

            noms.Reverse();
            Console.WriteLine("\nApres Reverse() :");
            noms.ForEach(n => Console.WriteLine(n));

            noms.RemoveAt(0);
            noms.RemoveRange(0, 2);
            Console.WriteLine("\nApres RemoveAt(0) et RemoveRange(0, 2) :");
            noms.ForEach(n => Console.WriteLine(n));

            string[] tableau = new string[noms.Count];
            noms.CopyTo(tableau);
            Console.WriteLine("\nCopyTo -> tableau de {0} elements", tableau.Length);

          
        }
    }
}