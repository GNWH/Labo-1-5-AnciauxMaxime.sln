using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    class Cercle : Forme, IEstDans
    {
        #region Attributs--------------------------------------------------------------

        private int rayon;

        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Constructeurs----------------------------------------------------------

        public Cercle() : this(new Coordonnees(0, 0), 0)
        {
        }

        public Cercle(Coordonnees coords, int rayon)
        {
            this.pointAccroche = coords;
            this.rayon = rayon;
        }

        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Propriétées------------------------------------------------------------

        public int Rayon { get; set; }

        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public override void Affiche()
        {
            Console.WriteLine($"Cercle de rayon {rayon} accroché au point {pointAccroche}\n");
        }

        public override string ToString()
        {
            return $"Cercle({rayon}){pointAccroche}";
        }

        public bool CoordonneeEstDans(Coordonnees p)
        {
            return (p.X-pointAccroche.X)*(p.X-pointAccroche.X) + (p.Y-pointAccroche.Y)*(p.Y-pointAccroche.Y) <= rayon*rayon ;
        }
    }
}