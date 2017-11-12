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

        public TicBoard(int players)
        {
            InitializeComponent();
            playernum = players;
        }

        public int playernum = 1;

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

        int round = O;
        private void pBoard_Click(object sender, EventArgs e)
        {
            
            if (board[cX,cY]==0)
            {
                if(!delay.Enabled && !checkWin())
                {
                    board[cX, cY] = round;
                    if (checkWin())
                    {
                        string pname = (round == O) ? "O" : "X";
                        drawBoard();
                        playerLabel.Text = $"{pname} Win";
                        return;
                    }
                    changeTurn();
                    drawBoard();
                    if(playernum==1) delay.Enabled = true;
                }
            }
        }

        bool checkWin()
        {
            bool result = false;
            int a = board[0, 0];
            int b = board[0, 1];
            int c = board[0, 2];
            int d = board[1, 0];
            int e = board[1, 1];
            int f = board[1, 2];
            int g = board[2, 0];
            int h = board[2, 1];
            int i = board[2, 2];

            if (a == b && b == c && a>0) result = true;
            else if (d == e && e == f && d>0) result = true;
            else if (g == h && h == i && g>0) result = true;

            else if (a == d && d == g && a>0) result = true;
            else if (b == e && e == h && b>0) result = true;
            else if (c == f && f == i && c>0) result = true;

            else if (a == e && e == i && a>0) result = true;
            else if (c == e && e == g && c>0) result = true;
            else result = false;

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
            String pname = (round == X) ? "X" : "O";
            lblTurn.Text = $"{pname}'s turn";
        }

        int player = O;
        int cX = 0, cY = 0;

        private void btnPlayerChange_Click(object sender, EventArgs e)
        {
            if(playernum==1)
            {
                player = (player == O) ? X : O;
                string pname = (player == O) ? "O" : "X";
                playerLabel.Text = $"You play as {pname}";
            }
            else
            {
                string pname = (player == O) ? "O" : "X";
                playerLabel.Text = $"{pname}'s turn";
            }
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            if(playernum==1)
            {
                if (round != player)
                {
                    Random r = new Random();
                    int x = r.Next(0, 3);
                    int y = r.Next(0, 3);
                    while(board[x,y]>0)
                    {
                        x = r.Next(0, 3);
                        y = r.Next(0, 3);
                        Console.WriteLine($"{x},{y}");
                    }
                    board[x,y] = round;
                    drawBoard();
                    changeTurn();
                    playerLabel.Text = "Your turn";
                    delay.Enabled = false;
                }
            }
        }

        private void pBoard_MouseMove(object sender, MouseEventArgs e)
        {
            cX = Convert.ToInt32(Math.Floor(Convert.ToDecimal(e.Y / 170)));
            cY = Convert.ToInt32(Math.Floor(Convert.ToDecimal(e.X / 170)));
            if(!delay.Enabled)
            {
                pBoard.Cursor = Cursors.Hand;
            }
            else
            {
                pBoard.Cursor = Cursors.Default;
            }
        }
    }
}
