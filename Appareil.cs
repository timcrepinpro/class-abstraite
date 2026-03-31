using System;
using System.Diagnostics.Contracts;

abstract class Appareil
{
    protected string marque;
    protected string modele;
    protected DateTime datefabrication;

    public Appareil(string marque, string modele, DateTime datefabrication){}

    public string GetMarque()
    {
        return marque;
    }
    public void SetMarque(string marque)
    {
        this.marque = marque;
    }
    public string GetModele()
    {
        return modele;
    }
    public void SetModele(string modele)
    {
        this.modele = modele;
    }
    public DateTime GetDateFabrication()
    {
        return datefabrication;
    }
    public void SetDateFabrication(DateTime datefabrication)
    {
        this.datefabrication = datefabrication;
    }
    public void Allumer()
    {
        Console.WriteLine("L'appareil est allumé.");
    
    }
    public virtual void AfficherType()
    {
        Console.WriteLine("Je suis un appareil.");
    
    }
    public virtual void AfficherGarantie()
    {
        Console.WriteLine("garantie stadard de lappareil");
    
    }
    public abstract void AfficherInfos();
    public abstract void CalculerAnciennete();


    


    
}




