using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    class Player
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public Point Location { get; set; }

        public Player(string name, int hitpoints, Point location)
        {
            Name = name;
            Hitpoints = hitpoints;
            Location = location;
        }
        public void Update()
        {

        }
        public void DrawPlayer(Graphics g)
        {

        }
        public void Interaction(int keyCode)
        {

        }
    }
}
