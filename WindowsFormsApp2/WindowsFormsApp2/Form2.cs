﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridHopper gridHopper = new GridHopper();
            this.Hide();
            gridHopper.Show();
            
        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string text = "======GRID HOPPER INSTRUCTION MANUAL ======== \n" +
               "\nThe aim of the game is to survive as long as possible. \n" +
               "\nYou control a box on the first left column of the grid.\n" +
               "\nYou can only make it move up or down your column.\n" +
               "\nAvoid the red boxes, select the row that has no red boxes in order to progress \n" +
               "\n ===================================";


            MessageBox.Show(text);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
