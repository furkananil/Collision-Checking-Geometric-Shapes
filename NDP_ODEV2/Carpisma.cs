using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ODEV2
{
    public static class Carpisma
    {
        public static bool cemberCarp(Cember c1, Cember c2)
        {
            float d = (float)Math.Sqrt(Math.Pow((c1.M.X - c2.M.X), 2) + Math.Pow((c1.M.Y - c2.M.Y), 2));
            //Console.WriteLine(d);
            if ((c1.R + c2.R) > d)
                return true;
            else
                return false;
        }
        public static bool kureCarp(Kure k1, Kure k2)
        {
            float d = (float)Math.Sqrt(Math.Pow((k1.M.X - k2.M.X), 2) +
                Math.Pow((k1.M.Y - k2.M.Y), 2) + Math.Pow((k1.M.Z - k2.M.Z), 2));
            //Console.WriteLine(d);
            if ((k1.R + k2.R) > (int)d)
                return true;
            else
                return false;
        }
        public static bool dikdortgenCarp(Dikdortgen d1, Dikdortgen d2)
        {
            int Xa = d1.M.X + d1.En / 2;
            int Ya = d1.M.Y + d1.Boy / 2;
            int Xb = d2.M.X + d2.En / 2;
            int Yb = d2.M.Y + d2.Boy / 2;

            if (Math.Abs(Xa - Xb) < (d1.En / 2 + d2.En / 2) && Math.Abs(Ya - Yb) < (d1.Boy / 2 + d2.Boy / 2))
                return true;
            else
                return false;
        }
        public static bool silindirCarp(Silindir k1, Silindir k2)
        {
            Nokta3d pa = new Nokta3d(k1.M.X, k1.M.Y + k1.H / 2, k1.M.Z);
            Nokta3d pb = new Nokta3d(k2.M.X, k2.M.Y + k2.H / 2, k2.M.Z);
            float d = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) +
                Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));
            //Console.WriteLine(d);
            if ((k1.R + k2.R) > (int)d && Math.Abs(pa.Y - pb.Y) < ((k1.H + k2.H) / 2))
                return true;
            else
                return false;
        }

        
    }
}
