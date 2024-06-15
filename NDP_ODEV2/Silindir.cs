using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ODEV2
{
    public class Silindir
    {
        Nokta3d m; int r; int h;
        public Silindir()
        {
            M = new Nokta3d();// merkez noktası
            R = 0;
            H = 0;
        }
        public Silindir(Nokta3d p, int r, int h)
        { M = p; R = r; H = h; }

        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }
        internal Nokta3d M { get => m; set => m = value; }


    }
}
