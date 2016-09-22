using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    class Cell
    {
        public Point Index { get; set; }
        public Point Location { get; set; }
        public SoortCell Soort { get; set; }

        public void Draw(Graphics g)
        {

        }
    }
}
