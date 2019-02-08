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
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
            string userName = UserNameBox.Text;
            StreamWriter sw = new StreamWriter("C:/Users/swive/Desktop/Dundee/Year2_sem2/AC22005 Comp Systems 2B/MyProject/Grid-Hopper/WindowsFormsApp2/Extras/leaderboardUser.txt");
            sw.WriteLine(userName);
            sw.Close();
          
        }

        private void LeaderBoardBox_TextChanged(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:/Users/swive/Desktop/Dundee/Year2_sem2/AC22005 Comp Systems 2B/MyProject/Grid-Hopper/WindowsFormsApp2/Extras/leaderboardUser.txt");

        }
    }
}
