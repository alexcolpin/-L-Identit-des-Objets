namespace L_Identité_des_Objets;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Produit article = new ProduitPerissable("B05", "Lait", 15.0, 5);

        Console.WriteLine(article.GetType());
    }
}