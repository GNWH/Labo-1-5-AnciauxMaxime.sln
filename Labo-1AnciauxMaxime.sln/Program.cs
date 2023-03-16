using Labo_1AnciauxMaxime.sln;
using static System.Console;

class Program
{
    static void Main()
    {
        Cercle circle1 = new Cercle(new Coordonnees(5, 5), 6);
        Cercle circle2 = new Cercle(new Coordonnees(6, 12), 15);
        Carre square1 = new Carre(new Coordonnees(7, 4), 2);
        Carre square2 = new Carre(new Coordonnees(4, 3), 8);
        Rectangle rectangle1 = new Rectangle(new Coordonnees(9, 8), 7, 1);
        Rectangle rectangle2 = new Rectangle(new Coordonnees(12, 13), 16, 10);

        List<Forme> listeFormes = new List<Forme>();

        listeFormes.Add(circle1);
        listeFormes.Add(circle2);
        listeFormes.Add(square1);
        listeFormes.Add(square2);
        listeFormes.Add(rectangle1);
        listeFormes.Add(rectangle2);

        Console.WriteLine("Liste des objets :--------------------------------------------------\n");
        foreach (var variable in listeFormes) variable.Affiche();
        Console.WriteLine("____________________________________________________________________");

        Console.WriteLine("\nListe des objets implémentant l'interface ISommets :----------------\n");
        foreach (var variable in listeFormes)
            if (variable is ISommets)
                variable.Affiche();
        Console.WriteLine("____________________________________________________________________");

        Console.WriteLine("\nListe des objets n'implémentant pas l'interface Isommets :----------\n");
        foreach (var variable in listeFormes)
            if (variable is not ISommets)
                variable.Affiche();
        Console.WriteLine("____________________________________________________________________\n");

        List<Carre> carres = new List<Carre>(5);

        carres.Add(new Carre(new Coordonnees(1, 2), 3));
        carres.Add(new Carre(new Coordonnees(1, 0), 2));
        carres.Add(new Carre(new Coordonnees(3, 5), 5));
        carres.Add(new Carre(new Coordonnees(4, 1), 1));
        carres.Add(new Carre(new Coordonnees(2, 3), 4));
        carres.Add(new Carre(new Coordonnees(6, 9), 2));
        carres.Add(new Carre(new Coordonnees(4, 2), 2));

        Console.WriteLine("Liste des carrés dans l'ordre de leur insertion :-------------------\n");
        foreach (var variable in carres) variable.Affiche();
        carres.Sort();
        Console.WriteLine("____________________________________________________________________\n");

        Console.WriteLine("Affichage des carrés triés par taille : ----------------------------\n");
        foreach (var variable in carres) variable.Affiche();
        Console.WriteLine("____________________________________________________________________\n");

        carres.Sort(new FormeAbscisseComparer());

        Console.WriteLine("\nAffichage des carrés triés par abscisse du point d'accroche : ------\n");
        foreach (var variable in carres) variable.Affiche();
        Console.WriteLine("____________________________________________________________________\n");

        Console.WriteLine("\nRésultat de recherche de tous les carrés correspondants à un autre de référence :---\n");
        var carresTrouves = carres.FindAll(c => c.Longueur == square1.Longueur);
        if (carresTrouves is not null)
            foreach (Carre VARIABLE in carresTrouves)
                VARIABLE.Affiche();
        else Console.WriteLine("Aucun résultat");
        Console.WriteLine("____________________________________________________________________________________\n");

        Console.WriteLine("Formes contenant un point spécifique :--------------------------------\n");
        Coordonnees coordRech = new Coordonnees(5, 5);
        var rechCoords = listeFormes.FindAll(f => f.CoordonneeEstDans(coordRech) is true);
        if (rechCoords.Count() > 0) {foreach (var variable in rechCoords) {variable.Affiche();}}
        else {Console.WriteLine($"Aucune forme ne contient le point {coordRech}");}
        Console.WriteLine("______________________________________________________________________\n");


        Console.WriteLine("Affichage des formes classées par la taille de leur surface dans l'ordre croissant------");
        listeFormes.Sort(new CompareSurfaceForme());
        foreach (var var in listeFormes) {Console.WriteLine(var+" d'une surface de "+MathUtil.Surface(var));}
        Console.WriteLine("________________________________________________________________________________________");





    }
}