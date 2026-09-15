namespace SecretNumber
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
            txtGuess = new TextBox();
            btnGuess = new Button();
            label1 = new Label();
            lstAttempt = new ListBox();
            SuspendLayout();
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(67, 110);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(113, 31);
            txtGuess.TabIndex = 0;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(67, 175);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(113, 38);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(67, 51);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 3;
            label1.Text = "Guess a number from 100 - 1";
            label1.Click += label1_Click_1;
            // 
            // lstAttempt
            // 
            lstAttempt.FormattingEnabled = true;
            lstAttempt.Location = new Point(278, 110);
            lstAttempt.Name = "lstAttempt";
            lstAttempt.Size = new Size(180, 129);
            lstAttempt.TabIndex = 4;
            lstAttempt.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 295);
            Controls.Add(lstAttempt);
            Controls.Add(label1);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGuess;
        private Button btnGuess;
        private Label label1;
        private ListBox lstAttempt;
    }
}
