namespace L_Identité_des_Objets;

class Program
{
    static void Main()
    {
        Produit p1 = new Produit("A01", "Souris", 15.0);
        Produit p2 = new Produit("A01", "Souris", 15.0);

        Console.WriteLine(p1.Equals(p2));
        }
}