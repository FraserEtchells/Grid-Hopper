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
            this.GameOverMsg = new System.Windows.Forms.RichTextBox();
            this.EndMsg = new System.Windows.Forms.RichTextBox();
            this.TryAgainBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ScoreMsg = new System.Windows.Forms.RichTextBox();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.RichTextBox();
            this.EntUserNameMsg = new System.Windows.Forms.TextBox();
            this.LeaderBoardBox = new System.Windows.Forms.RichTextBox();
            this.LeaderboardMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GameOverMsg
            // 
            this.GameOverMsg.BackColor = System.Drawing.Color.Purple;
            this.GameOverMsg.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverMsg.ForeColor = System.Drawing.SystemColors.Window;
            this.GameOverMsg.Location = new System.Drawing.Point(12, 36);
            this.GameOverMsg.Name = "GameOverMsg";
            this.GameOverMsg.ReadOnly = true;
            this.GameOverMsg.Size = new System.Drawing.Size(222, 55);
            this.GameOverMsg.TabIndex = 0;
            this.GameOverMsg.Text = "Game Over!";
            this.GameOverMsg.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // EndMsg
            // 
            this.EndMsg.BackColor = System.Drawing.Color.Purple;
            this.EndMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndMsg.ForeColor = System.Drawing.SystemColors.Window;
            this.EndMsg.Location = new System.Drawing.Point(9, 118);
            this.EndMsg.Name = "EndMsg";
            this.EndMsg.ReadOnly = true;
            this.EndMsg.Size = new System.Drawing.Size(278, 40);
            this.EndMsg.TabIndex = 1;
            this.EndMsg.Text = "Better luck next time!";
            // 
            // TryAgainBtn
            // 
            this.TryAgainBtn.Location = new System.Drawing.Point(27, 242);
            this.TryAgainBtn.Name = "TryAgainBtn";
            this.TryAgainBtn.Size = new System.Drawing.Size(206, 55);
            this.TryAgainBtn.TabIndex = 2;
            this.TryAgainBtn.Text = "Try Again?";
            this.TryAgainBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(27, 326);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(205, 54);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "I\'ll call it a day ;)";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ScoreMsg
            // 
            this.ScoreMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreMsg.Location = new System.Drawing.Point(414, 46);
            this.ScoreMsg.Name = "ScoreMsg";
            this.ScoreMsg.ReadOnly = true;
            this.ScoreMsg.Size = new System.Drawing.Size(158, 42);
            this.ScoreMsg.TabIndex = 4;
            this.ScoreMsg.Text = "Your Score Was:";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.Location = new System.Drawing.Point(592, 56);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(89, 28);
            this.ScoreBox.TabIndex = 5;
            this.ScoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(389, 131);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(303, 50);
            this.UserNameBox.TabIndex = 6;
            this.UserNameBox.Text = "";
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // EntUserNameMsg
            // 
            this.EntUserNameMsg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.EntUserNameMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntUserNameMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntUserNameMsg.Location = new System.Drawing.Point(389, 110);
            this.EntUserNameMsg.Name = "EntUserNameMsg";
            this.EntUserNameMsg.ReadOnly = true;
            this.EntUserNameMsg.Size = new System.Drawing.Size(150, 20);
            this.EntUserNameMsg.TabIndex = 7;
            this.EntUserNameMsg.Text = "Enter Your Name:";
            // 
            // LeaderBoardBox
            // 
            this.LeaderBoardBox.Location = new System.Drawing.Point(382, 242);
            this.LeaderBoardBox.Name = "LeaderBoardBox";
            this.LeaderBoardBox.ReadOnly = true;
            this.LeaderBoardBox.Size = new System.Drawing.Size(334, 232);
            this.LeaderBoardBox.TabIndex = 8;
            this.LeaderBoardBox.Text = "";
            // 
            // LeaderboardMsg
            // 
            this.LeaderboardMsg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LeaderboardMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeaderboardMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardMsg.Location = new System.Drawing.Point(382, 221);
            this.LeaderboardMsg.Name = "LeaderboardMsg";
            this.LeaderboardMsg.ReadOnly = true;
            this.LeaderboardMsg.Size = new System.Drawing.Size(172, 20);
            this.LeaderboardMsg.TabIndex = 9;
            this.LeaderboardMsg.Text = "Leaderboards";
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.LeaderboardMsg);
            this.Controls.Add(this.LeaderBoardBox);
            this.Controls.Add(this.EntUserNameMsg);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ScoreMsg);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.TryAgainBtn);
            this.Controls.Add(this.EndMsg);
            this.Controls.Add(this.GameOverMsg);
            this.Name = "EndForm";
            this.Text = "EndForm";
            this.Load += new System.EventHandler(this.EndForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox GameOverMsg;
        private System.Windows.Forms.RichTextBox EndMsg;
        private System.Windows.Forms.Button TryAgainBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.RichTextBox ScoreMsg;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.RichTextBox UserNameBox;
        private System.Windows.Forms.TextBox EntUserNameMsg;
        private System.Windows.Forms.RichTextBox LeaderBoardBox;
        private System.Windows.Forms.TextBox LeaderboardMsg;
    }
}