namespace L_Identité_des_Objets;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        
        List<object> inventaire = new List<object>();

        inventaire.Add(1); 
        inventaire.Add("Depot A"); 
        Produit p1 = new Produit("A01", "Souris", 15.0);
        inventaire.Add(p1);

        foreach (object item in inventaire)
        {
            
            Console.WriteLine("Type : " + item.GetType());

            
            Console.WriteLine("Valeur : " + item.ToString());

            
            if (item is Produit p)
            {
                Console.WriteLine("Code article : " + p.GetCodeArticle());
            }

            Console.WriteLine("-----");
        }
    }
}