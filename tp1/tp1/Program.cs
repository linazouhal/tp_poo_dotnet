using System.Runtime.CompilerServices;
using tp1;

class Program
{
    static void Main(string[] args)
    {
        Salarie s1=new Salarie();
        Salarie s2= new Salarie(10,"lina","zouhal",5000,0.25);
        Salarie s4= new Salarie(14,"sara","ziani",10000,0.25);
        Salarie s3 = new Salarie(s2);
        Console.WriteLine("**************le salarie S1*************");
        s1.affichage();
        Console.WriteLine("**************le salarie S2*************");
        s2.affichage();
        Console.WriteLine("**************le salarie S3*************");
        s3.affichage();
        Console.WriteLine("**************le salarie S4*************");
        s4.affichage();
        double c1, c2, c3, c4;
        c1=s1.CalculerSalaireNet();
        c2=s2.CalculerSalaireNet();
        c3=s3.CalculerSalaireNet();
        c4=s4.CalculerSalaireNet();
        Console.WriteLine("**************SalaireNet 1***************");
        Console.WriteLine(c1);
        Console.WriteLine("**************SalaireNet 2***************");
        Console.WriteLine(c2);
        Console.WriteLine("**************SalaireNet 3***************");
        Console.WriteLine(c3);
        Console.WriteLine("**************SalaireNet 4***************");
        Console.WriteLine(c4);

        Commercial com1 = new Commercial(1,"Alami", "Sara",5000,0.25, 20000, 0.05);
        Commercial com2 = new Commercial();
        Console.WriteLine("************** Premier commercial****************");
        Console.WriteLine(com1.ToString());
        Console.WriteLine("**************Deuxieme commercial****************");
        Console.WriteLine(com2.ToString());
        Console.WriteLine("**************Salaire net 1 :*****************");
        Console.WriteLine( com1.CalculerSalaireNet() + " DH");
        Console.WriteLine("**************Les deux commerciaux sont-ils egaux ?*************** ");
        Console.WriteLine( com1.Equals(c2));
        Console.WriteLine("=== GESTION DES OBJETS POSTAUX ===");
        Console.WriteLine("1. Envoyer une lettre");
        Console.WriteLine("2. Envoyer un colis");
        Console.Write("Votre choix : ");

        int choix = int.Parse(Console.ReadLine());

        Console.Write("Nom du destinataire : ");
        string nom = Console.ReadLine();

        Console.Write("Adresse : ");
        string adresse = Console.ReadLine();

        Console.Write("Code postal : ");
        int codePostal = int.Parse(Console.ReadLine());

        Console.Write("Ville : ");
        string ville = Console.ReadLine();

        Console.Write("Envoi recommande ? (oui/non) : ");
        bool recommande =
            Console.ReadLine().ToLower() == "oui";

        ObjetPostal objet = null;

        if (choix == 1)
        {
            Console.Write("Lettre urgente ? (oui/non) : ");
            bool urgente =
                Console.ReadLine().ToLower() == "oui";

            objet = new Lettre(nom, adresse, codePostal, ville,recommande, urgente );
        }
        else if (choix == 2)
        {
            Console.Write("Poids du colis en grammes : ");
            double poids = double.Parse(Console.ReadLine());

            objet = new Colis(
                nom, adresse, codePostal, ville,
                recommande, poids
            );
        }
        else
        {
            Console.WriteLine("Choix invalide !");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Prix a payer : "+ objet.Prix().ToString("F2") + " euros");

        int choix2 = -1;

        while (choix2 != 0)
        {
            Console.WriteLine("\n===== MENU CENTRE DE FORMATION =====");
            Console.WriteLine("1. Calculer l'age d'un stagiaire");
            Console.WriteLine("2. Calculer le salaire total d'un employe");
            Console.WriteLine("3. Comparer deux salles");
            Console.WriteLine("0. Quitter");
            Console.Write("Votre choix : ");

            choix = int.Parse(Console.ReadLine());

            if (choix2 == 1)
            {
                Stagiaire s = new Stagiaire(
                    101, "Alami", "Sara",
                    new DateTime(2004, 5, 10),
                    "AB123456", "2eme annee", "Informatique",
                    3, 1
                );

                Console.WriteLine(
                    "Age : " + s.CalculerAge(DateTime.Today) + " ans"
                );
            }
            else if (choix2 == 2)
            {
                Employe e = new Employe(
                    201, "Amrani", "Youssef",
                    new DateTime(1990, 3, 15),
                    new DateTime(2020, 9, 1),
                    6000, 10
                );

                Console.Write("Remuneration par heure : ");
                double remHeure = double.Parse(Console.ReadLine());

                Console.WriteLine(
                    "Salaire total : "
                    + e.CalculTotalSalaire(remHeure) + " DH"
                );
            }
            else if (choix2 == 3)
            {
                Salle salle1 = new Salle(1, "Specialisee", 20, 10);
                Salle salle2 = new Salle(2, "Specialisee", 25, 10);

                if (salle1.Equals(salle2))
                {
                    Console.WriteLine("Les salles sont egales.");
                }
                else
                {
                    Console.WriteLine("Les salles sont differentes.");
                }
            }
            else if (choix2 == 0)
            {
                Console.WriteLine("Fin du programme.");
            }
            else
            {
                Console.WriteLine("Choix invalide !");
            }
        }
    }


}
