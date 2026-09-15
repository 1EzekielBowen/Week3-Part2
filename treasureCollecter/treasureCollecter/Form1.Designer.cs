namespace treasureCollecter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstScore = new ListBox();
            btnPlay = new Button();
            SuspendLayout();
            // 
            // lstScore
            // 
            lstScore.FormattingEnabled = true;
            lstScore.Location = new Point(50, 52);
            lstScore.Name = "lstScore";
            lstScore.Size = new Size(269, 154);
            lstScore.TabIndex = 0;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(143, 300);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(112, 34);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "button1";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 364);
            Controls.Add(btnPlay);
            Controls.Add(lstScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstScore;
        private Button btnPlay;
    }
}
