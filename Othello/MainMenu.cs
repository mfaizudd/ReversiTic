using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        Players b = new Players();
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (b.IsDisposed) b = new Players();
            b.gametype = "reversi";
            Support.adduc(b,Parent,this);
            ((MainForm)Parent.Parent).label1.Text = "Select Players";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Top = Convert.ToInt32(Math.Floor(Convert.ToDecimal(Height / 2)) - Math.Floor(Convert.ToDecimal(tableLayoutPanel1.Height / 2)));
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            if (b.IsDisposed) b = new Players();
            b.gametype = "tictactoe";
            Support.adduc(b, Parent, this);
            ((MainForm)Parent.Parent).label1.Text = "Select Players";
        }
    }
}
