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
    public partial class Players : UserControl
    {
        public Players()
        {
            InitializeComponent();
        }
        public string gametype = "";

        private void btnBack_Click(object sender, EventArgs e)
        {
            Support.back(Parent, this);
            ((MainForm)Parent.Parent).label1.Text = "Main Menu";
            this.Dispose();
        }

        
        Board b = new Board();
        TicBoard tb = new TicBoard();
        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            switch (gametype)
            {
                case "reversi":
                    if (b.IsDisposed) b = new Board();
                    Support.adduc(b, Parent, this);
                    b.setMode(2);
                    ((MainForm)Parent.Parent).label1.Text = "Playing Multiplayer Reversi";
                    b.drawBoard();
                    break;
                case "tictactoe":
                    if (tb.IsDisposed) tb = new TicBoard();
                    tb.playernum = 2;
                    Support.adduc(tb, Parent, this);
                    ((MainForm)Parent.Parent).label1.Text = "Playing Multiplayer Tic Tac Toe";
                    break;
                default:
                    break;
            }
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            switch (gametype)
            {
                case "reversi":
                    if (b.IsDisposed) b = new Board();
                    Support.adduc(b, Parent, this);
                    b.setMode(1);
                    ((MainForm)Parent.Parent).label1.Text = "Playing Singleplayer Reversi";
                    b.drawBoard();
                    break;
                case "tictactoe":
                    if (tb.IsDisposed) tb = new TicBoard();
                    Support.adduc(tb, Parent, this);
                    ((MainForm)Parent.Parent).label1.Text = "Playing Singleplayer Tic Tac Toe";
                    break;
                default:
                    break;
            }
        }

        private void Players_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Top = Convert.ToInt32(Math.Floor(Convert.ToDecimal(Height / 2))-Math.Floor(Convert.ToDecimal(tableLayoutPanel1.Height/2)));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
