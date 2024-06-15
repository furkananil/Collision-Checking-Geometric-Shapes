using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ODEV2
{
    public class Nokta
    {
        int x;
        int y;
        public Nokta()
        { X = 0; Y = 0; }
        public Nokta(int x, int y)
        { X = x; Y = y; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }

    public class Nokta3d : Nokta 
    {
        int z;
        public Nokta3d() : base()
        { Z = 0; }
        public Nokta3d(int x, int y, int z)
        { Z = z; }
        public int Z { get => z; set => z = value; }

    }
}
