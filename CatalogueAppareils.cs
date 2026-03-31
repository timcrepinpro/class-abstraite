class CatalogueAppareil
{
    private List<Appareil> appareils;

    public CatalogueAppareil()
    {
        appareils = new List<Appareil>();
    }

    public void AjouterAppareil(Appareil appareil)
    {
        appareils.Add(appareil);
    }
    public void AfficherCatalogue()
    {
        foreach (Appareil appareil in appareils)
        {
            Console.WriteLine(appareil.ToString());
        }
    }
    
    public void RechercherAppareil(string modele)
    {
        try
        {
           foreach (Appareil appareil in appareils)
            {
                if (appareil.GetModele() == modele)
                {
                    Console.WriteLine(appareil.ToString());
                }
            } 
        }
        catch (Exception e)
        {
            Console.WriteLine("Aucun appareil trouvé pour cette clé.");
            Console.WriteLine(e.Message);
        }
        
    }
}
