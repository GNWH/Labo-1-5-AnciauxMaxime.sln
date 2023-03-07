
using System;
using System.Drawing;
using Labo_1AnciauxMaxime.sln;
using static System.Console;


class Program
{
    static void Main()
    {
        Cercle circle1 = new Cercle(new Coordonnees(5,5),6);
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

        Console.WriteLine("\nListe des objets implémentants l'interface ISommets :---------------\n");
        foreach (var variable in listeFormes) if (variable is ISommets) variable.Affiche();
        Console.WriteLine("____________________________________________________________________");

        Console.WriteLine("\nListe des objets n'implémentatns pas l'interface Isommets :---------\n");
        foreach (var variable in listeFormes) if (variable is not ISommets) variable.Affiche();
        Console.WriteLine("____________________________________________________________________\n");


        List<Carre> carres = new List<Carre>(5);

        carres.Add(new Carre(new Coordonnees(1, 2), 3));
        carres.Add(new Carre(new Coordonnees(1, 0), 2));
        carres.Add(new Carre(new Coordonnees(3, 5), 5));
        carres.Add(new Carre(new Coordonnees(4, 1), 1));
        carres.Add(new Carre(new Coordonnees(2, 3), 4));
        carres.Add(new Carre(new Coordonnees(6, 9), 2));
        carres.Add(new Carre(new Coordonnees(4, 2), 2));
        foreach (var variable in carres) variable.Affiche();
        carres.Sort();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~=");
        foreach (var variable in carres) variable.Affiche();
        carres.Sort(new FormeAbscisseComparer());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~=");
        foreach (var variable in carres) variable.Affiche();
        //Essais ratés :
        Predicate<Carre> predicate = Carre.CompareLong;
        List<Carre> carres1 = carres.FindAll(square1.Longueur);
    }

}
