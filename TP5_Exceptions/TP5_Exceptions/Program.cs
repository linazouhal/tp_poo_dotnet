namespace TP5_Exceptions
{
   
    class ErreurAgeException : Exception
    {
        public ErreurAgeException()
        {
            Console.WriteLine("Erreur: Age négatif");
        }
    }

   
    class Personne
    {
        private string nom = "";
        private string prenom = "";
        private int age;
        private static int nbPersonnes;

        public Personne()
        {
            nbPersonnes++;
        }

        public Personne(string nom, string prenom, int age)
        {
          
            if (age <= 0) throw new ErreurAgeException();
            else
            {
                this.nom = nom;
                this.prenom = prenom;
                this.Age = age;
                nbPersonnes++;
            }
        }

        public Personne(Personne p)
        {
            nom = p.Nom;
            prenom = p.Prenom;
            Age = p.Age;
            nbPersonnes++;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0) throw new ErreurAgeException();
                else age = value;
            }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public static int NbPersonnes
        {
            get { return nbPersonnes; }
        }

        public void afficher()
        {
            Console.WriteLine("nom: " + nom + "\tprenom: " + prenom + "\tage: " + Age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string? choix;
            do
            {
                Console.WriteLine("\n========== TP5 : Gestion des exceptions ==========");
                Console.WriteLine("1 - Division par zero SANS gestion (le programme plante)");
                Console.WriteLine("2 - Division par zero avec try/catch");
                Console.WriteLine("3 - Plusieurs catch (FormatException / OverflowException)");
                Console.WriteLine("4 - try / catch / finally");
                Console.WriteLine("5 - Exception personnalisee (ErreurAgeException)");
                Console.WriteLine("0 - Quitter");
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1": DivisionSansGestion(); break;
                    case "2": DivisionAvecTryCatch(); break;
                    case "3": PlusieursCatch(); break;
                    case "4": TryCatchFinally(); break;
                    case "5": ExceptionPersonnalisee(); break;
                }
            } while (choix != "0");
        }

      
        static void DivisionSansGestion()
        {
            Console.WriteLine("\n--- Exercice 1 : sans gestion (le programme va s'arreter) ---");
            int j = 20, i = 0;
            Console.WriteLine(j / i);
            Console.WriteLine("Fin du programme !");  
        }

        static void DivisionAvecTryCatch()
        {
            Console.WriteLine("\n--- Exercice 2 : try/catch ---");
            int j = 20, i = 0;
            try
            {
                Console.WriteLine(j / i);
                Console.WriteLine("Fin du programme !");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("division par zero");
            }
        }

     
        static void PlusieursCatch()
        {
            Console.WriteLine("\n--- Exercice 3 : plusieurs catch ---");
            int nombre = 0;
            Console.Write("Entrez un nombre : ");
            string? chaine = Console.ReadLine();
            try
            {
                nombre = Int32.Parse(chaine ?? "");
                Console.WriteLine("Nombre valide : " + nombre);
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("FormatException : " + formEx.Message);
            }
            catch (OverflowException overEx)
            {
                Console.WriteLine("OverflowException : " + overEx.Message);
            }
        
        }

        static void TryCatchFinally()
        {
            Console.WriteLine("\n--- Exercice 4 : finally ---");
            Console.Write("Entrez un diviseur : ");
            try
            {
                int d = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("100 / " + d + " = " + (100 / d));
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("L'erreur suivante s'est produite : {0}", ex.GetType().Name + " - " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Bloc finally : toujours execute (exception ou non).");
            }
            Console.WriteLine("Instruction suivante.");
        }


        static void ExceptionPersonnalisee()
        {
            Console.WriteLine("\n--- Exercice 5 : ErreurAgeException ---");
            Personne p = new Personne("asri", "yassine", 23);
            p.afficher();

            Console.WriteLine("donner l'age");
            try
            {
                p.Age = int.Parse(Console.ReadLine() ?? "");
            }
            catch (ErreurAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez saisir un nombre entier.");
            }
            p.afficher();

            try
            {
                Personne p2 = new Personne("alami", "ahmed", -5);
            }
            catch (ErreurAgeException)
            {
                Console.WriteLine("Constructeur : personne non creee. NbPersonnes = " + Personne.NbPersonnes);
            }
        }
    }
}