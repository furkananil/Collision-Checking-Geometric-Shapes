using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ODEV2
{
    public class Cember
    {
        Nokta m; int r;
        public Cember()
        {
            M = new Nokta();// merkez noktası
            R = 0;
        }
        public Cember(Nokta p, int r)
        { M = p; R = r; }

        public int R { get => r; set => r = value; }
        internal Nokta M { get => m; set => m = value; }


    }
}
