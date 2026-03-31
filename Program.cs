namespace class_abstraites;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Appareil> appareils = new List<Appareil> { 
            new Ordinateur("c1castj", "bonjour", DateTime.Now,32)
            
        };
        foreach (object Appareil in appareils)
            {
                if (Appareil is Ordinateur)
                {
                    Ordinateur Ordinateur = (Ordinateur)Appareil;
                    Ordinateur.AfficherType();
                    Ordinateur.AfficherInfos();
                    Ordinateur.CalculerAnciennete();
                    Console.WriteLine(Ordinateur.ToString());


                }
                
            }

    }
}





/*
ex1
q1
la class apareil est abstaite car elle ser juste a avoir un paterne pour les class fille
q2
non car cest une class abstraites
q3 
virtual peut etre apeller dans la class mere pas abstact car virtual peut etre remplacer , abstract dois etre cree dans la class fille

ex2
q1 to string serv a afficher les info de maniere brut pour les developeur

*/