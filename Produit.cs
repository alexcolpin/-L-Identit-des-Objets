class Produit
{
    private string codeArticle;
    private string designation;
    private double prix;

    public Produit(string code, string nom, double px)
    {
        codeArticle = code;
        designation = nom;
        prix = px;
    }

    public string GetCodeArticle()
    {
        return codeArticle;
    }

    //  Redéfinition de ToString
    public override string ToString()
    {
        return $"Produit {{ code={codeArticle}, nom={designation}, prix={prix} }}";
    }
    public override bool Equals(object obj)
    {
        if (obj is Produit autre)
        {
            return this.codeArticle == autre.codeArticle;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(codeArticle);
    }
}