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

        private void start_Click(object sender, EventArgs e)
        {
            /*fájlba kiírja az értékeket 
            és elindítja a játékot*/
            string difficulty = "";
            string player_1_character = "";
            string player_2_character = "";
            string name_of_the_player1 = player1name.Text;
            string name_of_the_player2 = player2name.Text;
            StreamWriter sw = new StreamWriter("difficulty.txt");
            if (difficulty_easy.Visible)
            {
                difficulty = "easy";
            }
            else if (difficulty_normal.Visible)
            {
                difficulty = "normal";
            }
            else if (difficulty_hard.Visible)
            {
                difficulty = "hard";
            }

            if (player1_o.Visible)
            {
                player_1_character = "o";
            }
            else if (player1_x.Visible)
            {
                player_1_character = "x";
            }

            if (player2_o.Visible)
            {
                player_2_character = "o";
            }
            else if (player1_x.Visible)
            {
                player_2_character = "x";
            }
            sw.WriteLine($"{difficulty},{name_of_the_player1},{player_1_character},{name_of_the_player2},{player_2_character}");
            sw.Flush();
            sw.Close();
            difficulty_arrow_left.Hide();
            difficulty_arrow_right.Hide();
            difficulty_easy.Hide();
            difficulty_hard.Hide();
            difficulty_normal.Hide();
            difficulty_title.Hide();
            player1name.Hide();
            player1_arrow_left.Hide();
            player1_arrow_right.Hide();
            player1_o.Hide();
            player1_x.Hide();
            player2name.Hide();
            player2_arrow_left.Hide();
            player2_arrow_right.Hide();
            player2_o.Hide();
            player2_x.Hide();
            start.Hide();
            Game game = new Game();
            this.Controls.Add(game);
        }


    }
}
