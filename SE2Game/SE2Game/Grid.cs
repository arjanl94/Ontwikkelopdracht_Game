using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    public class Grid
    {
        public Size gridSize { get; set; }
        public Size cellSize { get; set; }
        public Size cellCount { get; set; }
        public Point Objective { get; set; } 
        public List<Cell> cells { get; set; }

        public Grid(Size grid, Size cellsize, Size cellcount, Point objective)
        {
            gridSize = grid;
            cellSize = cellsize;
            Objective = objective;
        }
        public void DrawMap(Graphics g)
        {

        }
        public Point freePosition()
        {
            Point Position = new Point();
            return Position;
        }
        public SoortCell cellTypeAtPosition(Point position)
        {
            Point index = PositionToCellIndex(position);
            int arrayIndex = (index.Y * this.cellCount.Width) + index.X;
            return this.cells[arrayIndex].soort;
        }

        private Point PositionToCellIndex(Point position)
        {
            Size cs = this.cellSize;
            return new Point((position.X - (position.X % cs.Width)) / cs.Width,
                             (position.Y - (position.Y % cs.Height)) / cs.Height);
        }
    }
}
