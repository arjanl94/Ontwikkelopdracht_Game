using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    class World
    {
        public bool Winner { get; private set; }
        public bool Loser { get; private set; }
        public Player player { get; set; }
        public List<Enemy> enemies { get; private set; }
        public List<Map> maps { get; private set; }

        public void Update()
        {

        }
        public void Draw(Graphics g)
        {

        }
    }
}
