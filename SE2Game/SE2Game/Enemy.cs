using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2Game
{
    public class Enemy : Character
    {
        public int Damage { get; set; }

        public Enemy(int hitpoints, int damage, Point location) :base(hitpoints, location)
        {
            Damage = damage;
            Hitpoints = hitpoints;
            Location = location;
        }
        public void Update()
        {

        }
        public void DrawEnemy(Graphics g)
        {

        }
        public void Attack(Player player)
        {

        }
    }
}
