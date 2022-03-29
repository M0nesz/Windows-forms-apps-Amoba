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
        //fájlba kiírja az értékeket 
    }
}
