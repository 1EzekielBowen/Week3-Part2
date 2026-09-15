namespace treasureCollecter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(57, 54, 54);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int treausre = 1;

            lstScore.Items.Clear();

            while (treausre <= 10)
            {
                lstScore.Items.Add("Treasure " + treausre + " collected!"); 
                treausre++;
            }
        }
    }
}
