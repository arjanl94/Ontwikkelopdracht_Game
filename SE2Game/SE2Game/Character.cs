using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    public abstract class Character
    {
        public int Hitpoints { get; set; }
        public Point Location { get; set; }

        public Character(int hitpoints, Point location)
        {
            Hitpoints = hitpoints;
            Location = location;
        }
    }
}
