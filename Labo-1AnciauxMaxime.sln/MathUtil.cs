using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    internal class MathUtil
    {
        public static int Surface(Carre carre) {return carre.Longueur * carre.Longueur;}

        public static int Surface(Cercle cercle) {return (int) (3.14159265359 * cercle.Rayon * cercle.Rayon);}

        public static int Surface(Rectangle rectangle) {return rectangle.Longueur * rectangle.Largeur;}

    }
}
