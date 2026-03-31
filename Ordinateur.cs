class Ordinateur : Appareil
{
    private double tailleecran;

    public Ordinateur(string marque, string modele, DateTime datefabrication, double tailleecran): base(marque, modele, datefabrication)
    {
        this.tailleecran = tailleecran;
        this.marque = marque;
        this.modele = modele;
        this.datefabrication = datefabrication;
    
    }
    

    public double GetTailleEcran()
    {
        return tailleecran;
    }
    public void SetTailleEcran(double tailleecran)
    {
        this.tailleecran = tailleecran;
    }
    public override void AfficherType()
    {
        Console.WriteLine("Je suis un ordinateur.");
    }
    public override void AfficherInfos()
    {
        Console.WriteLine("Marque : " + marque);
        Console.WriteLine("Modèle : " + modele);
        Console.WriteLine("Date de fabrication : " + datefabrication);
        Console.WriteLine("Taille d'écran : " + tailleecran + " pouces");
    
    }


    public override void CalculerAnciennete()
    {
        DateTime today = DateTime.Now;
        int age = today.Year - datefabrication.Year;
        Console.WriteLine("L'ordinateur a " + age + " ans.");
    }

    public override string ToString()
    {
        return marque + modele + datefabrication + tailleecran;
    }
}