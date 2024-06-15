using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ODEV2
{
    public class Kure
    {
        Nokta3d m; int r;
        public Kure()
        {
            M = new Nokta3d();// merkez noktası
            R = 0;
        }
        public Kure(Nokta3d p, int r)
        { M = p; R = r; }

        public int R { get => r; set => r = value; }
        internal Nokta3d M { get => m; set => m = value; }

    }
}
