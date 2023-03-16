using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    public class Rectangle:Forme, IEstDans, ISommets
    {
        private int longueur;
        private int largeur;

        public Rectangle() :this(new Coordonnees(0,0), 0,0) { }

        public Rectangle(Coordonnees coords, int longueur, int largeur)
        {
            this.pointAccroche = coords;
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public int Longueur
        {
            get => this.longueur;
            set => this.longueur = value;
        }

        public int Largeur
        {
            get => this.largeur;
            set => this.largeur = value;
        }

        public override void Affiche()
        {
            Console.WriteLine($"Rectangle de longueur = {longueur}, largeur = {largeur} et point d'accroche {pointAccroche}\n");
        }
        public override string ToString()
        {
            return $"Rectangle({longueur}, {largeur}){pointAccroche}";
        }

        public override bool CoordonneeEstDans(Coordonnees p)
        {
            return p.X >= pointAccroche.X && p.X <= pointAccroche.X + Longueur && p.Y >= pointAccroche.Y && p.Y <= pointAccroche.Y + largeur;
            //return p.X >= pointAccroche.X && p.X <= pointAccroche.X + Longueur && p.Y <= pointAccroche.Y && p.Y >= pointAccroche.Y - largeur;
        }

        public int NbrSommets()
        {
            return 4;
        }
    }
}
