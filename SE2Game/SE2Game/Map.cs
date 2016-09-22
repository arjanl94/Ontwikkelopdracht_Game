using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    class Map
    {
        public Size Grid { get; set; }
        public Size cellSize { get; set; }
        public Size cellCount { get; set; }
        public Point Objective { get; set; } 
        public List<Cell> cells { get; set; }

        public void DrawMap(Graphics g)
        {

        }
    }
}
