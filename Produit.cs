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
}