namespace WindowsFormsApp2
{
    partial class GridHopper
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
            this.LiveMsgBox = new System.Windows.Forms.TextBox();
            this.LivesMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LiveMsgBox
            // 
            this.LiveMsgBox.Location = new System.Drawing.Point(601, 90);
            this.LiveMsgBox.Name = "LiveMsgBox";
            this.LiveMsgBox.Size = new System.Drawing.Size(143, 22);
            this.LiveMsgBox.TabIndex = 0;
            this.LiveMsgBox.TextChanged += new System.EventHandler(this.LiveMsgBox_TextChanged);
            // 
            // LivesMsg
            // 
            this.LivesMsg.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LivesMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LivesMsg.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesMsg.Location = new System.Drawing.Point(601, 62);
            this.LivesMsg.Name = "LivesMsg";
            this.LivesMsg.ReadOnly = true;
            this.LivesMsg.Size = new System.Drawing.Size(63, 21);
            this.LivesMsg.TabIndex = 1;
            this.LivesMsg.Text = "Lives";
            // 
            // GridHopper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LivesMsg);
            this.Controls.Add(this.LiveMsgBox);
            this.Name = "GridHopper";
            this.Text = "GridHopper";
            this.Load += new System.EventHandler(this.GridHopper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LiveMsgBox;
        private System.Windows.Forms.TextBox LivesMsg;
    }
}

