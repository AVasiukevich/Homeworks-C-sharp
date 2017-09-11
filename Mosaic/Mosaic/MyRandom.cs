using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosaic
{
    public static class Randomer
    {
        static Random rnd;
        static Randomer()
        {
            rnd = new Random();
        }
        public static int Next()
        {
            return rnd.Next();
        }
        public static int Next(int a, int b)
        {
            return rnd.Next(a, b);
        }
    }
}
