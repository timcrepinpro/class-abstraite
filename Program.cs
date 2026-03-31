namespace class_abstraites;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Appareil> appareils = new List<Appareil> { 
            new Ordinateur("c1castj", "bonjour", DateTime.Now,32),
            new Smartphone("c1castj", "bonjour", DateTime.Now,32),
            new Smartphone("c1castj", "bonjour", new DateTime(2007, 11, 14),32),
            new Ordinateur("c1castj", "bonjour", new DateTime(2007, 11, 14),32)
            
        };


        Ordinateur o1 = new Ordinateur("c1castj", "bonjour", new DateTime(2007, 11, 14),32);
        Ordinateur o2 = new Ordinateur("c1castj", "bonjour", new DateTime(2007, 11, 14),32);
        Smartphone s1 = new Smartphone("c1castj", "bonjour", new DateTime(2007, 11, 14),32);


        HashSet<Appareil> panier = new HashSet<Appareil>();
        panier.Add(o1);
        panier.Add(o2);
        panier.Add(s1);
        Console.WriteLine(panier.Count);
        




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
                else if (Appareil is Smartphone)
                {
                    Smartphone Smartphone = (Smartphone)Appareil;
                    Smartphone.AfficherType();
                    Smartphone.AfficherInfos();
                    Smartphone.CalculerAnciennete();
                    Console.WriteLine(Smartphone.ToString());
                }
                
            }

        foreach (object paire in panier)
        {
            if ( paire is Ordinateur)
            {
                    Ordinateur Ordinateur = (Ordinateur)paire;
                    Ordinateur.AfficherType();
                    Ordinateur.AfficherInfos();
                    Ordinateur.CalculerAnciennete();
                    Console.WriteLine(Ordinateur.ToString());
            }
            if ( paire is Smartphone)
            {
                    Smartphone Smartphone = (Smartphone)paire;
                    Smartphone.AfficherType();
                    Smartphone.AfficherInfos();
                    Smartphone.CalculerAnciennete();
                    Console.WriteLine(Smartphone.ToString());
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


ex4
les donnes sont sous le type datetime

ex5
car se sont les class fille de Appareil

ex6
il serv a pouvoir ajouter les instance a tout moment

ex7 
le try catch dans cetet fonction est utile car la chance quil y ai une errreur du fait quelle communique avec un utilisateur

*/