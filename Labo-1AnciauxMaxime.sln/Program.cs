
using System;
using Labo_1AnciauxMaxime.sln;
using static System.Console;


class Program
{
    static void Main()
    {
        Cercle circle = new Cercle(new Coordonnees(5,5),6);
        circle.Affiche();
        Console.WriteLine(circle);
    }

}
