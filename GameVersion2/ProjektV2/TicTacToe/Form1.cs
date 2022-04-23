namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //ButtonBorderStyle button  = ButtonBorderStyle.None;
        //bool player1 = true;
        bool player2 = false;
        int next = 0;
        
      
        
        public Form1()
        {
            InitializeComponent();

            
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Player1 won the match");
            }

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            next++;

            if (next %2 == 0)
            {
                player2 = true;
                button1.Text = "O";
                button1.Enabled = false;
            }
            else
            {
                button1.Text = "X";
                button1.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button2.Text = "O";
                button2.Enabled = false;
            }
            else
            {
                button2.Text = "X";
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button3.Text = "O";
                button3.Enabled = false;
            }
            else
            {
                button3.Text = "X";
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button4.Text = "O";
                button4.Enabled = false;
            }
            else
            {
                button4.Text = "X";
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button5.Text = "O";
                button5.Enabled = false;
            }
            else
            {
                button5.Text = "X";
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button6.Text = "O";
                button6.Enabled = false;
            }
            else
            {
                button6.Text = "X";
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button7.Text = "O";
                button7.Enabled = false;
            }
            else
            {
                button7.Text = "X";
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button8.Text = "O";
                button8.Enabled = false;
            }
            else
            {
                button8.Text = "X";
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            next++;

            if (next % 2 == 0)
            {
                player2 = true;
                button9.Text = "O";
                button9.Enabled = false;
            }
            else
            {
                button9.Text = "X";
                button9.Enabled = false;
            }
        }

        
    }
}