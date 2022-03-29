namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //elrejti az objektumokat a fõmenüben
            Title.Hide();
            start.Hide();
            scores.Hide();
            credits.Hide();
            //meghívja és elõhozza a nehézségválasztó menüt
            Difficulty difficulty = new Difficulty();  
            //difficulty.Show(); ne használd nem mûködik :/
            this.Controls.Add(difficulty);
        }
    }
}