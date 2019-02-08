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
        Boolean trackButton = false;
        Boolean success = true;
        int score = 0;
        int lives = 3;
        private static System.Timers.Timer movementTimer;
        private static System.Timers.Timer buttonTrackTimer;
        private static System.Timers.Timer checkSuccessTimer;


        public GridHopper()
        {
            InitializeComponent();

            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(75 * i, 75 * j, 60, 60); //70 width and height is perfect to make all the grid align, dont change them
                    btn[i, j].BackColor = Color.LightGray;
                    btn[i, j].Click += new EventHandler(this.btnEvent_Click);
                    Controls.Add(btn[i, j]);
                }

            }

            for (int i = 1; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j].Enabled = false; //prevents the user clicking on buttons outwith the first column
                }
            }

            SetMovementTimer();
            SetButtonTrackTimer();
        }

        private void colourSwap()
        {
            for (int i = 0; i < btn.GetLength(1); i++)
            {
                btn[4, i].BackColor = Color.Red; // by default, set all of the first line to red;
            }

            int x = rand.Next(4) + 1; //number of green squares this rotation
            int j = 0;
            while (j < x) // sets the specified number of green squares from above
            {
                int y = rand.Next(5); //chooses a random position within the button array

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

        private void btnEvent_Click(object sender, EventArgs e) //checks whether a green button was clicked or a red button was clicked
        {
            if (((Button)sender).BackColor.Equals(Color.Green))
            {
                success = true;
            }
            else
            {
                success = false;
            }

        }

        private void copyColor() //allows each row to copy the color of the row to it's right, simulating the movement of the grid
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j].BackColor = btn[i + 1, j].BackColor;
                }
            }

        }

        private void SetMovementTimer()
        {
            movementTimer = new System.Timers.Timer(1000);
            movementTimer.Elapsed += ShiftGrid;
            movementTimer.AutoReset = true;
            movementTimer.Enabled = true;
        }

        private void ShiftGrid (Object source, System.Timers.ElapsedEventArgs e)
        {
            success = false;
            copyColor();
            colourSwap();
            if(trackButton == true)
            {
                SetCheckSuccessTimer();
            }
        }

        private void SetButtonTrackTimer()
        {
            buttonTrackTimer = new System.Timers.Timer(5000);
            buttonTrackTimer.Elapsed += BeginButtonTrack;
            buttonTrackTimer.AutoReset = false;
            buttonTrackTimer.Enabled = true;
        }

        private void BeginButtonTrack(Object source, System.Timers.ElapsedEventArgs e)
        {
            trackButton = true;
            Console.WriteLine("Beginning Button Track");
        }

        private void SetCheckSuccessTimer()
        {
            checkSuccessTimer = new System.Timers.Timer(800);
            checkSuccessTimer.Elapsed += CheckSuccess;
            checkSuccessTimer.AutoReset = false;
            checkSuccessTimer.Enabled = true;
        }

        private void LiveMsgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckSuccess(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Checking Success");
            if (success == true)
            {
                Console.WriteLine("hit");
                score++;
               
            }
            else
            {
                Console.WriteLine("miss");
                lives--;
                
            }

            if (lives == 0)
            {
                LiveMsgBox.Text = lives.ToString();

               // Console.WriteLine("0 lives");
                Console.WriteLine(score);
                Application.Exit();
            }
   
        }

       
      
    }
}
