﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE2Game
{
    public partial class Form1 : Form
    {
        World world = new World();
        public Form1()
        {
            InitializeComponent();
            world.Create();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            world.grid.DrawGrid(e.Graphics);
        }
    }
}
