class Smartphone : Appareil
{
    private int nbcapteurphoto;

    public Smartphone(string marque, string modele, DateTime datefabrication, int nbcapteurphoto): base(marque, modele, datefabrication)
    {
        this.nbcapteurphoto = nbcapteurphoto;
        this.marque = marque;
        this.modele = modele;
        this.datefabrication = datefabrication;
    
    }
    public int GetNbCapteurPhoto()
    {
        return nbcapteurphoto;
    }
    public void SetNbCapteurPhoto(int nbcapteurphoto)
    {
        this.nbcapteurphoto = nbcapteurphoto;
    }


    public override void AfficherInfos()
    {
        Console.WriteLine("Marque : " + marque);
        Console.WriteLine("Modèle : " + modele);
        Console.WriteLine("Date de fabrication : " + datefabrication);
        Console.WriteLine("Nombre de capteurs de photo : " + nbcapteurphoto);
    }
    public override void CalculerAnciennete()
    {
        DateTime today = DateTime.Now;
        int age = today.Year - datefabrication.Year;
        Console.WriteLine("Le smartphone a " + age + " ans.");
        
    }
    public override void AfficherType()
    {
        Console.WriteLine("Je suis un smartphone.");
    }
    public override string ToString()
    {
        return marque + modele + datefabrication + nbcapteurphoto;
    }
    
}