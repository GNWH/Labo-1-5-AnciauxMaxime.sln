using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    public class MathUtil
    {
        public static int Surface(Forme x)
        {
            if (x is Carre) return Surface((Carre)x);
            if (x is Rectangle) return Surface((Rectangle)x);
            if (x is Cercle) return Surface((Cercle)x);
            throw new InvalidCastException();
        }
        public static int Surface(Carre carre) {return carre.Longueur * carre.Longueur;}

        public static int Surface(Cercle cercle) {return (int) (3.14159265359 * cercle.Rayon * cercle.Rayon);}

        public static int Surface(Rectangle rectangle) {return rectangle.Longueur * rectangle.Largeur;}
    }
}
