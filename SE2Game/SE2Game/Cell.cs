using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    public class Cell
    {
        public Point Index { get; set; }
        public Point Location { get; set; }
        public SoortCell soort { get; set; }

        private static Pen penField = new Pen(Color.Black, 1);
        private static Pen penWall = new Pen(Color.Black, 3);
        private static Pen penGoal = new Pen(Color.Black, 3);
        private static SolidBrush brushField = new SolidBrush(Color.FromArgb(255, 255, 255));
        private static SolidBrush brushGoal = new SolidBrush(Color.FromArgb(86, 178, 14));
        private static SolidBrush brushWall = new SolidBrush(Color.FromArgb(0, 0, 0));

        public Cell(Point index, Point location, SoortCell soort)
        {
            Index = index;
            Location = location;
            this.soort = soort;
        }
        public void Draw(Graphics g)
        {
            Pen pen;
            Brush brush;

            if (soort == SoortCell.Field)
            {
                pen = penField;
                brush = brushField;
            }
            else if (soort == SoortCell.Wall)
            {
                pen = penWall;
                brush = brushWall;
            }
            else if (soort == SoortCell.Goal)
            {
                pen = penGoal;
                brush = brushGoal;
            }
        }
    }
}
