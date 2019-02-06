using System;
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
    public partial class GridHopper : Form
    { 
        Random rand = new Random();
        Button[,] btn = new Button[5, 5];
        Boolean success = true;
        int score = 0;
        int lives = 3;
        private static System.Timers.Timer movementTimer;

        public GridHopper()
        {
            InitializeComponent();

            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(100 * i, 100 * j, 60, 60); //70 width and height is perfect to make all the grid align, dont change them
                    btn[i, j].BackColor = Color.LightGray;
                    btn[i, j].Click += new EventHandler(this.btnEvent_Click);
                    Controls.Add(btn[i, j]);
                }

            }

            for (int i = 1; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j].Enabled = false;
                }
            }

            SetTimer();
        }

        void colourSwap()
        {
             for (int i = 0; i < btn.GetLength(1); i++)
            {
                btn[4, i].BackColor = Color.Red; // by default, set all of the first line to red;
            }

            int x = rand.Next(4) +1; //number of green squares this rotation
            Console.WriteLine(x);
            int j = 0;
            while (j < x) // sets the specified number of green squares from above
              {
                 int y = rand.Next(4);

                if (btn[4, y].BackColor.Equals(Color.Red))
                 {
                     btn[4, y].BackColor = Color.Green;
                    j++;
                 }
              }
        }

        private void GridHopper_Load(object sender, EventArgs e)
        {

        }

        void btnEvent_Click(object sender, EventArgs e) 
        {
            if (((Button)sender).BackColor.Equals(Color.Green))
            {
                success = true;
            }
            else
            {
                success = false;
            }

            checkSuccess();

        }

        void checkSuccess()
        {
            if(success == true)
            {
                score++;
            }
            else
            {
                lives--;
            }
        }

        void copyColor()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j].BackColor = btn[i + 1, j].BackColor;
                }
            }
     
        }

        private void SetTimer() //Constructed using Microsoft Docs
        {
            movementTimer = new System.Timers.Timer(1000);
            movementTimer.Elapsed += OnTimedEvent;
            movementTimer.AutoReset = true;
            movementTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            copyColor();
            colourSwap();
        }

    }
}
