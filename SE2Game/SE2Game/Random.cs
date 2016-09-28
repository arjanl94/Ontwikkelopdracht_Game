using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2Game
{
    public static class Random
    {
        private static System.Random random = new System.Random();
        public static int Next()
        {
            return random.Next();
        }
        public static int Next(int maxvalue)
        {
            return random.Next(maxvalue);
        }
        public static int Next(int minvalue, int maxvalue)
        {
            return random.Next(minvalue, maxvalue);
        }
    }
}
