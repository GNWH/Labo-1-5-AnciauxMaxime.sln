using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    class Carre:Forme, IEstDans
    {
        /*
         * Créer une classe Carre qui hérite de Forme et décrite par : une valeur
           entière représentant la longueur du coté (variable membre et propriété),
           un constructeur d’initialisation, un constructeur par défaut, la surcharge
           de la méthode ToString(), la redéfinition de la méthode Affiche() qui
           affiche les informations concernant le carré dans la console.

         */

        #region Attributs--------------------------------------------------------------

        private int longueur;

        #endregion
        #region Constructeurs----------------------------------------------------------

        #region Propriétés ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public int Longueur
        {
            get => longueur;
            set => longueur = value;
        }

        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Constructeur par defaut-----------------------------------------------

        public Carre() : this(new Coordonnees(0, 0), 0)
        {
        }

        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Constructeur d'initialisation ----------------------------------------
        public Carre(Coordonnees coords, int longueur)
        {
            pointAccroche = coords;
            this.longueur = longueur;
        }
        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Methodes---------------------------------------------------------------

        public override string ToString()
        {
            return $"Carré({longueur})" + pointAccroche;
        }

        public override void Affiche()
        {
            Console.WriteLine($"Carré de longueur {longueur} accroché au point {pointAccroche}\n");
        }
        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public bool CoordonneeEstDans(Coordonnees p)
        {
            return p.X >= pointAccroche.X && p.X <= pointAccroche.X + longueur && p.Y >= pointAccroche.Y && p.Y <= pointAccroche.Y + longueur;
            //return p.X >= pointAccroche.X && p.X <= pointAccroche.X + longueur && p.Y <= pointAccroche.Y && p.Y >= pointAccroche.Y - longueur;
        }
    }
}
