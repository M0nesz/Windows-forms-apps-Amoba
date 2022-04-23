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
    public partial class ExitScreen : Form
    {
        public ExitScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen mainMenu = new HomeScreen(); 
            mainMenu.Show();
        }
    }
}
