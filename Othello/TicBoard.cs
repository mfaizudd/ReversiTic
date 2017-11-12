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
    public partial class TicBoard : UserControl
    {
        public TicBoard()
        {
            InitializeComponent();
        }

        private void TicBoard_Load(object sender, EventArgs e)
        {
            resetBoard();
        }

        const int X = 1;
        const int O = 2;
        int[,] board = new int[,] { 
            { 2,0,1 },
            { 0,1,2 },
            { 1,0,2 }
        };
        int boxSize = (int)Math.Ceiling(Convert.ToDecimal(510 / 3));

        public void drawBoard()
        {
            Bitmap b = new Bitmap(512, 512);
            Graphics g = Graphics.FromImage(b);
            Font f = new Font(FontFamily.GenericSansSerif, 125);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            int x = 0, y = 0;
            for (int i = 0; i < 510; i+=boxSize)
            {
                x = 0;
                for (int j = 0; j < 510; j+=boxSize)
                {
                    g.DrawRectangle(Pens.Gray, i, j, boxSize, boxSize);
                    if(board[x,y]==X)
                    {
                        g.DrawString("X", f, Brushes.Gray, i-5, j-10);
                    }
                    else if(board[x,y]==O)
                    {
                        g.DrawString("O", f, Brushes.Gray, i-5, j-10);
                    }
                    x++;
                }
                y++;
            }
            pBoard.Image = b;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Support.back(Parent, this);
            ((MainForm)Parent.Parent).label1.Text = "Players";
            this.Dispose();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            drawBoard();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            resetBoard();
        }

        private void resetBoard()
        {
            board = new int[,] {
                { 0,0,0 },
                { 0,0,0 },
                { 0,0,0 }
            };
            drawBoard();
        }

        int round = X;
        private void pBoard_Click(object sender, EventArgs e)
        {
            if(board[cX,cY]==0)
            {
                board[cX, cY] = round;
                if(checkWin()==true)
                {
                    string pname = (round == O) ? "O" : "X";

                    playerLabel.Text = $"{pname} Win";
                }
                changeTurn();
                drawBoard();
            }
        }

        bool checkWin()
        {
            bool result = false;

            playerLabel.Text = $"{round} win";

            return result;
        }

        bool checkWin(int match)
        {
            bool result = false;

            for (int i = 0; i < 3; i++)
            {
                int matchfound = 0;
                for (int j = 0; j < 3; j++)
                {
                    if(board[i,j]==match)
                    {
                        matchfound++;
                        if (matchfound == 3) return true;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int matchfound = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (board[j,i] == match)
                    {
                        matchfound++;
                        if (matchfound == 3) return true;
                    }
                }
            }

            return result;
        }

        void changeTurn()
        {
            round = (round == X) ? O : X;
        }

        int cX = 0, cY = 0;
        private void pBoard_MouseMove(object sender, MouseEventArgs e)
        {
            cX = Convert.ToInt32(Math.Floor(Convert.ToDecimal(e.Y / 170)));
            cY = Convert.ToInt32(Math.Floor(Convert.ToDecimal(e.X / 170)));
        }
    }
}
