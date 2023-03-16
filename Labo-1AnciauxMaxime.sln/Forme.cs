using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    public abstract class Forme : IEstDans
    {
        #region Declaration des attributs :--------------------------------------------

        protected Coordonnees pointAccroche;

        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Constructeurs----------------------------------------------------------

        #region Constucteur par défaut------------------------------------------------
        public Forme()
        {
            pointAccroche = new Coordonnees();
        }
        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Proprietes-------------------------------------------------------------
        public Coordonnees PointAccroche
        {
            get => pointAccroche;
            set => pointAccroche = value;
        }
        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region Methodes---------------------------------------------------------------
        public abstract void Affiche();
        public abstract bool CoordonneeEstDans(Coordonnees p);
        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    }
}
