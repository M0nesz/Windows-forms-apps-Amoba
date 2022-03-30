using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Difficulty : UserControl
    {
        public Difficulty()
        {
            InitializeComponent();
            difficulty_hard.Hide();
            difficulty_easy.Hide();
            player1_o.Hide();
            player2_x.Hide();
        }

        private void difficulty_arrow_left_Click(object sender, EventArgs e)
        {
            if (difficulty_normal.Visible)
            {
                difficulty_normal.Hide();
                difficulty_easy.Show();
            }
            else if (difficulty_hard.Visible)
            {
                difficulty_hard.Hide();
                difficulty_normal.Show();
            }
        }

        private void difficulty_arrow_right_Click(object sender, EventArgs e)
        {
            if (difficulty_easy.Visible)
            {
                difficulty_normal.Show();
                difficulty_easy.Hide();
            }
            else if (difficulty_normal.Visible)
            {
                difficulty_normal.Hide();
                difficulty_hard.Show();
            }
        }

        private void player1_arrow_left_Click(object sender, EventArgs e)
        {
            if (player1_x.Visible)
            {
                player1_x.Hide();
                player1_o.Show();
            }
            else if (player1_o.Visible)
            {
                player1_x.Show();
                player1_o.Hide();
            }
        }

        private void player1_arrow_right_Click(object sender, EventArgs e)
        {
            if (player1_x.Visible)
            {
                player1_x.Hide();
                player1_o.Show();
            }
            else if (player1_o.Visible)
            {
                player1_x.Show();
                player1_o.Hide();
            }
        }

        private void player2_arrow_left_Click(object sender, EventArgs e)
        {
            if (player2_o.Visible)
            {
                player2_o.Hide();
                player2_x.Show();
            }
            else if (player2_x.Visible)
            {
                player2_o.Show();
                player2_x.Hide();
            }
        }

        private void player2_arrow_right_Click(object sender, EventArgs e)
        {
            if (player2_o.Visible)
            if (player2_o.Visible)
                {
                player2_o.Hide();
                player2_x.Show();
            }
            else if (player2_x.Visible)
            {
                player2_x.Hide();
                player2_o.Show();
            }
        }

        //fájlba kiírja az értékeket 
    }
}
