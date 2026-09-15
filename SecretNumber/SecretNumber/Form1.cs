namespace SecretNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(57, 54, 54);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int secretNumber = new Random().Next(1, 101);
            int guess = Convert.ToInt32(txtGuess.Text);

            while (guess != secretNumber)
            {
                if (guess < secretNumber)
                {
                    lstAttempt.Items.Add("Too low! Try again.");
                }
                else
                {
                    lstAttempt.Items.Add("Too high! Try again.");
                }
                return;
                
            }
                
            lstAttempt.Items.Add("Congratulations! You guessed the secret number: " + secretNumber);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
