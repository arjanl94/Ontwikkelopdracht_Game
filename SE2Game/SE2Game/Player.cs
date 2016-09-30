using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SE2Game
{
    public class Player : Character
    {
        public string Name { get; set; }
        public bool powerUp { get; set; }
        public Player(string name, int hitpoints, Point location) :base(hitpoints, location)
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
