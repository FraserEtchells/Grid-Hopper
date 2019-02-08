using System;
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
            ScoreMsg.Text = "Your score is: " + finalScore.ToString();
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

        private void TryAgainBtn_Click(object sender, EventArgs e)
        {
            MainMenu restartMainMenu = new MainMenu();
            //this.Invoke((Action)delegate { EndForm.ActiveForm.Close(); }); // constructed from https://stackoverflow.com/questions/18718303/cross-thread-operation-not-valid-when-trying-to-hide-the-form as there seemed to be no other solution/guidelines on how to deal with threading issue
            this.Hide();
            restartMainMenu.ShowDialog();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {

        }
    }
}