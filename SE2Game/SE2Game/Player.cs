using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SE2Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public Point Location { get; set; }
        public bool powerUp { get; set; }

        public Player(string name, int hitpoints)
        {
            Name = name;
            Hitpoints = hitpoints;
        }
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
        public void Interaction(Keys key)
        {

        }
    }
}
