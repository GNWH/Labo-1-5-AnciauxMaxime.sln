using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    abstract class Forme
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
        #endregion ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    }
}
