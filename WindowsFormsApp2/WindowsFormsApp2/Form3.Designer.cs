using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class EndForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TryAgainBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ScoreMsg = new System.Windows.Forms.RichTextBox();
            this.EntUserNameMsg = new System.Windows.Forms.TextBox();
            this.LeaderBoardBox = new System.Windows.Forms.RichTextBox();
            this.LeaderboardMsg = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TryAgainBtn
            // 
            this.TryAgainBtn.Location = new System.Drawing.Point(40, 264);
            this.TryAgainBtn.Name = "TryAgainBtn";
            this.TryAgainBtn.Size = new System.Drawing.Size(206, 55);
            this.TryAgainBtn.TabIndex = 2;
            this.TryAgainBtn.Text = "Try Again?";
            this.TryAgainBtn.UseVisualStyleBackColor = true;
            this.TryAgainBtn.Click += new System.EventHandler(this.TryAgainBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(40, 337);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(205, 54);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Quit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ScoreMsg
            // 
            this.ScoreMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreMsg.Location = new System.Drawing.Point(460, 125);
            this.ScoreMsg.Name = "ScoreMsg";
            this.ScoreMsg.ReadOnly = true;
            this.ScoreMsg.Size = new System.Drawing.Size(263, 56);
            this.ScoreMsg.TabIndex = 4;
            this.ScoreMsg.Text = "";
            // 
            // EntUserNameMsg
            // 
            this.EntUserNameMsg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EntUserNameMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntUserNameMsg.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntUserNameMsg.Location = new System.Drawing.Point(40, 97);
            this.EntUserNameMsg.Name = "EntUserNameMsg";
            this.EntUserNameMsg.ReadOnly = true;
            this.EntUserNameMsg.Size = new System.Drawing.Size(150, 22);
            this.EntUserNameMsg.TabIndex = 7;
            this.EntUserNameMsg.Text = "Enter Your Name:";
            // 
            // LeaderBoardBox
            // 
            this.LeaderBoardBox.Location = new System.Drawing.Point(460, 225);
            this.LeaderBoardBox.Name = "LeaderBoardBox";
            this.LeaderBoardBox.ReadOnly = true;
            this.LeaderBoardBox.Size = new System.Drawing.Size(263, 232);
            this.LeaderBoardBox.TabIndex = 8;
            this.LeaderBoardBox.Text = "";
            // 
            // LeaderboardMsg
            // 
            this.LeaderboardMsg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LeaderboardMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeaderboardMsg.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardMsg.Location = new System.Drawing.Point(460, 201);
            this.LeaderboardMsg.Name = "LeaderboardMsg";
            this.LeaderboardMsg.ReadOnly = true;
            this.LeaderboardMsg.Size = new System.Drawing.Size(172, 22);
            this.LeaderboardMsg.TabIndex = 9;
            this.LeaderboardMsg.Text = "Leaderboard";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox.Location = new System.Drawing.Point(40, 125);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(263, 56);
            this.UserNameBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "Game Over";
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.LeaderboardMsg);
            this.Controls.Add(this.LeaderBoardBox);
            this.Controls.Add(this.EntUserNameMsg);
            this.Controls.Add(this.ScoreMsg);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.TryAgainBtn);
            this.Name = "EndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndForm";
            this.Load += new System.EventHandler(this.EndForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TryAgainBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.RichTextBox ScoreMsg;
        private System.Windows.Forms.TextBox EntUserNameMsg;
        private System.Windows.Forms.RichTextBox LeaderBoardBox;
        private System.Windows.Forms.TextBox LeaderboardMsg;
        private System.Windows.Forms.TextBox UserNameBox;
        private Label label1;
    }
}