using System;


class Client
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Numero { get; set; }
    public int Age { get; set; }

    public Client(string nom, string prenom, int numero, int age)
    {
        Nom = nom; Prenom = prenom; Numero = numero; Age = age;
    }

    public override bool Equals(object obj)
    {
        return obj is Client c && Nom == c.Nom && Prenom == c.Prenom
            && Numero == c.Numero && Age == c.Age;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nom, Prenom, Numero, Age);
    }

    public override string ToString()
    {
        return $"Client : {Nom} {Prenom}, n°{Numero}, {Age} ans";
    }
}

class Program
{
   
    static void PartieEntiers()
    {
        Console.WriteLine("=== Partie 1 : tableaux d'entiers ===");

        int[] T1 = new int[5];               
        int[] T2 = new int[5] { 1, 2, 3, 4, 5 };  
        int[] T3 = { 1, 2, 3, 4, 5 };         

        
        for (int i = 0; i < T1.Length; i++)
        {
            T1[i] = 0;
        }

        Console.WriteLine("Dernier élément de T2 : " + T2[4]);
        Console.WriteLine("Taille de T3 : " + T3.Length);
        Console.Write("T1 : ");
        foreach (int x in T1) Console.Write(x + " ");
        Console.WriteLine();
    }

    
    static void PartieNoms()
    {
        Console.WriteLine("\n=== Partie 2 : Reverse et Sort ===");

        string[] Noms = new string[5];

        Console.WriteLine("Entrer les noms de 5 employés :");
        for (int i = 0; i < Noms.Length; i++)
        {
            Noms[i] = Console.ReadLine();
        }

        Console.WriteLine("\nLe tableau saisi :");
        foreach (string nom in Noms) Console.Write("{0} ", nom);

        Array.Reverse(Noms);
        Console.WriteLine("\n\nLe tableau dans l'ordre inverse :");
        foreach (string nom in Noms) Console.Write("{0} ", nom);

        Array.Sort(Noms);
        Console.WriteLine("\n\nLe tableau trié :");
        foreach (string nom in Noms) Console.Write("{0} ", nom);
        Console.WriteLine();
    }

   
    static void PartieClients()
    {
        Console.WriteLine("\n=== Partie 3 : méthodes de Array avec Client ===");

        Client[] t = new Client[3];
        t[0] = new Client("Alami", "ali", 2, 16);
        t[1] = new Client("Alami", "fati", 2, 16);
        t[2] = new Client("salmi", "ahmed", 4, 17);

       
        foreach (Client a in t) Console.WriteLine(a.ToString());

        Client c = new Client("Alami", "fati", 2, 16);

        int i = Array.IndexOf(t, c);
        Console.WriteLine("la position de c est: " + i);        

   
        i = Array.LastIndexOf(t, c);
        Console.WriteLine("la position de c est: " + i);        

        Console.WriteLine("longueur=: " + t.GetLength(0));      

        Client[] T = new Client[3];
        
        Array.Copy(t, T, 3);

        t.CopyTo(T, 0);

        bool res = Array.Equals(t, T);
        Console.WriteLine("res= " + res);                     

    
        Array.Clear(T, 2, 1);

        Array.Resize(ref T, 2);
        foreach (Client a in T) Console.WriteLine(a.ToString());

       
        Console.WriteLine("type: " + t.GetType());             
    }

    static void Main(string[] args)
    {
        PartieEntiers();
        PartieNoms();
        PartieClients();
        Console.Read();
    }
}