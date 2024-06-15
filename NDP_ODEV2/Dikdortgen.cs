using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ODEV2
{
    public class Dikdortgen
    {
        Nokta m; int en; int boy;
        public Dikdortgen()
        {
            M = new Nokta(); //köşe noktası
            En = 0; Boy = 0;
        }
        public Dikdortgen(Nokta p, int en, int boy)
        { M = p; En = en; Boy = boy; }
        public Nokta M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
    }
}
