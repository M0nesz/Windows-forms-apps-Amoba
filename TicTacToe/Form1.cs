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
            //elrejti az objektumokat a f�men�ben
            Title.Hide();
            start.Hide();
            scores.Hide();
            credits.Hide();
            //megh�vja �s el�hozza a neh�zs�gv�laszt� men�t
            Difficulty difficulty = new Difficulty();  
            //difficulty.Show(); ne haszn�ld nem m�k�dik :/
            this.Controls.Add(difficulty);
        }
    }
}