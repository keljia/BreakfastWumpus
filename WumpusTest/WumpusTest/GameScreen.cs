﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        Graphics g;

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] doors = new bool[6];
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                doors[i] = true;
            }
            g = this.CreateGraphics();
            erase(g);
            Image top = Image.FromFile(@".\SuchArt\Cave top.png");
            Image topLeft = Image.FromFile(@".\SuchArt\Cave upper left.png");
            Image topRight = Image.FromFile(@".\SuchArt\Cave upper right.png");
            Image bottom = Image.FromFile(@".\SuchArt\Cave bottom.png");
            Image bottomLeft = Image.FromFile(@".\SuchArt\Cave lower left.png");
            Image bottomRight = Image.FromFile(@".\SuchArt\Cave lower right.png");
            Image topDoor = Image.FromFile(@".\SuchArt\Cave top door.png");
            Image topLeftDoor = Image.FromFile(@".\SuchArt\Cave upper left door.png");
            Image topRightDoor = Image.FromFile(@".\SuchArt\Cave upper right door.png");
            Image bottomDoor = Image.FromFile(@".\SuchArt\Cave bottom door.png");
            Image bottomLeftDoor = Image.FromFile(@".\SuchArt\Cave lower left door.png");
            Image bottomRightDoor = Image.FromFile(@".\SuchArt\Cave lower right door.png");

            Image[,] walls = {{top, topDoor},
                             {topLeft, topLeftDoor},
                             {topRight, topRightDoor},
                             {bottom, bottomDoor},
                             {bottomLeft, bottomLeftDoor},
                             {bottomRight, bottomRightDoor}};
            int[,] coordinates = { { 40, 1 }, { 1, 11 }, { 120, 11 }, { 40, 136 }, { 1, 79 }, { 120, 79 } };
            for (int i = 0; i < doors.Length; i++)
            {
                if (doors[i])
                {
                    g.DrawImage(walls[i, 1], coordinates[i, 0], coordinates[i, 1]);
                }
                else
                {
                    g.DrawImage(walls[i, 0], coordinates[i, 0], coordinates[i, 1]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            erase(g);
        }

        private void erase(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(240, 240, 240));
            g.FillRectangle(b, 0, 0, 200, 200);
        }
    }
}
