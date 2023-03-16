using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_1AnciauxMaxime.sln
{
    class CompareSurfaceForme: IComparer<Forme>
    {
        public int Compare(Forme x, Forme y)
        {
            return MathUtil.Surface(x) - MathUtil.Surface(y);
        }
    }
}
