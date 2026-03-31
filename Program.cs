namespace L_Identité_des_Objets;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        HashSet<Produit> panier = new HashSet<Produit>();

        Produit p1 = new Produit("A01", "Souris", 15.0);
        Produit p2 = new Produit("A01", "Souris", 15.0);

        panier.Add(p1);
        panier.Add(p2);

        Console.WriteLine(panier.Count);
    }
}