﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class EndForm : Form
    {
        int finalScore;

        public EndForm(int score)
        {
            InitializeComponent();
            finalScore = score;
            ScoreBox.Text = finalScore.ToString();
        }

        private void EndForm_Load(EventArgs e, object sender)
        {
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}