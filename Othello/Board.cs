using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class Board : UserControl
    {
        public int mode = 2;

        public void setMode(int value)
        {
            mode = value;
            playermode(mode);
        }

        public Board()
        {
            InitializeComponent();
        }

        int[,] playboard = new int[,] 
            { 
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,1 ,2,0,0,0},
                
                {0,0,0,2 ,1,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
            };

        const int white = 1;
        const int black = 2;
        const int valid = 3;
        const int none = 0;
        public void drawBoard()
        {
            Bitmap b = new Bitmap(512, 512);
            Graphics g = Graphics.FromImage(b);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.FillRectangle(Brushes.DarkGreen, 0, 0, 512, 512);
            int x = 0, y = 0;
            int counter = 0;
            int blackcounter = 0, whitecounter = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (playboard[i, j])
                    {
                        case valid:
                            playboard[i, j] = none;
                            break;
                        default:
                            break;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (playboard[i, j])
                    {
                        case none:
                            if (checkdirection(i, j))
                            {
                                counter++;
                                playboard[i, j] = valid;
                            }
                            break;
                        case white:
                            whitecounter++;
                            break;
                        case black:
                            blackcounter++;
                            break;
                        default:
                            break;
                    }
                }
            }
            blackLabel.Text = blackcounter.ToString();
            whiteLabel.Text = whitecounter.ToString();

            for (int i = 0; i < 512; i+=64)
            {
                y = 0;
                for (int j = 0; j < 512; j+=64)
                {
                    g.DrawRectangle(Pens.Black, j, i, 64, 64);
                    if(playboard[x,y]==white)
                    {
                        g.FillEllipse(Brushes.White, j+7, i+7, 50, 50);
                    }
                    else if(playboard[x,y]==black)
                    {
                        g.FillEllipse(Brushes.Black, j+7, i+7, 50, 50);
                    }
                    else if(playboard[x,y]==valid)
                    {
                        g.FillEllipse(Brushes.Blue, j + 24, i + 24, 16, 16);
                    }
                    y++;
                }
                x++;
            }
            if (counter < 1)
            {
                if (whitecounter > blackcounter)
                {
                    label1.Text = "White Win!";
                }
                else if (blackcounter > whitecounter)
                {
                    label1.Text = "Black Win!";
                }
                else
                {
                    label1.Text = "DRAW!";
                }
            }
            pBoard.Image = b;
        }

        int round = white;

        private void Board_Load(object sender, EventArgs e)
        {
            btnStart.PerformClick();
            
        }

        void playermode(int player)
        {
            if(player==1)
            {
                playerLabel.Visible = true;
                btnPlayerChange.Visible = true;
            }
            else if(player==2)
            {
                playerLabel.Visible = false;
                btnPlayerChange.Visible = false;
            }
            btnStart.PerformClick();
        }

        bool validDirection(int dirX, int dirY, int curX, int curY)
        {
            int match = (round == white) ? black : white;
            int x = curX + dirX;
            int y = curY + dirY;
            if (x < 0 || y < 0 || x > 7 || y > 7) return false;
            if(playboard[x,y]==match)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool makeMoveisValid(int indexX, int indexY)
        {
            if (playboard[indexX, indexY] <1 || playboard[indexX,indexY]==3 || matchFound == true)
            {
                if (
                validDirection(-1, -1, indexX, indexY) ||
                validDirection(-1, 0, indexX, indexY) ||
                validDirection(-1, 1, indexX, indexY) ||
                validDirection(0, -1, indexX, indexY) ||

                validDirection(0, 1, indexX, indexY) ||
                validDirection(1, -1, indexX, indexY) ||
                validDirection(1, 0, indexX, indexY) ||
                validDirection(1, 1, indexX, indexY)
                )
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        bool matchFound = false;

        bool checkdirection(int curX, int curY)
        {
            if(
               helpdirection(-1, -1, curX, curY) ||
               helpdirection(-1,  0, curX, curY) ||
               helpdirection(-1,  1, curX, curY) ||
               
               helpdirection(0, -1, curX, curY) ||
               helpdirection(0,  1, curX, curY) ||
               
               helpdirection(1, -1, curX, curY) ||
               helpdirection(1,  0, curX, curY) ||
               helpdirection(1,  1, curX, curY)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool helpdirection(int dirX, int dirY, int curX, int curY)
        {
            bool matchFound = false;
            if (makeMoveisValid(curX, curY))
            {
                int match = (round == white) ? black : white;
                int defX = curX;
                int defY = curY;
                bool end = false;

                if (validDirection(dirX, dirY, curX, curY))
                {
                    curX += dirX;
                    curY += dirY;
                    while (curX > -1 && curY > -1 && curX < 8 && curY < 8 && end == false)
                    {
                        if (playboard[curX, curY] == round)
                        {
                            end = true;
                            matchFound = true;
                        }
                        else if (playboard[curX, curY] == none || playboard[curX,curY]==valid)
                        {
                            matchFound = false;
                            end = true;
                        }
                        else
                        {
                            curX += dirX;
                            curY += dirY;
                        }
                    }
                    return matchFound;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        void direction(int dirX, int dirY,int curX, int curY)
        {
            if(makeMoveisValid(curX, curY))
            {
                int match = (round == white) ? black : white;
                int defX = curX;
                int defY = curY;
                bool end = false;
                
                if(validDirection(dirX,dirY,curX,curY))
                {
                    curX += dirX;
                    curY += dirY;
                    while (curX > -1 && curY > -1 && curX < 8 && curY < 8 && end == false)
                    {
                        if(playboard[curX,curY]==round)
                        {
                            if(matchFound==false)
                            {
                                matchFound = true;
                            }
                            if(curX==defX&&curY==defY)
                            {
                                return;
                            }
                            else
                            {
                                curX -= dirX;
                                curY -= dirY;
                                playboard[curX, curY] = round;
                            }
                        }
                        else if(playboard[curX,curY]==none)
                        {
                            return;
                        }
                        else
                        {
                            curX += dirX;
                            curY += dirY;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }

        void move()
        {
            direction(-1, -1, inX, inY);
            direction(-1, 0, inX, inY);
            direction(-1, 1, inX, inY);

            direction(0, -1, inX, inY);
            direction(0, 1, inX, inY);

            direction(1, -1, inX, inY);
            direction(1, 0, inX, inY);
            direction(1, 1, inX, inY);

            drawBoard();
            if (matchFound==true)
            {
                changeTurn();
                matchFound = false;
            }
            drawBoard();
        }

        void move(int inX, int inY)
        {
            direction(-1, -1, inX, inY);
            direction(-1, 0, inX, inY);
            direction(-1, 1, inX, inY);

            direction(0, -1, inX, inY);
            direction(0, 1, inX, inY);

            direction(1, -1, inX, inY);
            direction(1, 0, inX, inY);
            direction(1, 1, inX, inY);

            if (matchFound == true)
            {
                changeTurn();
                matchFound = false;
            }
            drawBoard();
        }

        private void pBoard_Click(object sender, EventArgs e)
        {
            if(makeMoveisValid(inX,inY))
            {
                //playboard[inX, inY] = round;
                if(mode==1)
                {
                    if(playerround==round)
                    {
                        move();
                    }
                }
                else
                {
                    move();
                }
            }
        }

        private void changeTurn()
        {
            if (round == white)
            {
                round = black;
                label1.Text = "Black's Turn";
            }
            else
            {
                round = white;
                label1.Text = "White's Turn";
            }
            if(mode==1)
            {
                drawBoard();
                //computerMove();
            }
        }

        private void computerMove()
        {
            int compround = (playerround == white) ? black : white;
            if (round == compround)
            {
                Random rand = new Random();
                int newX = rand.Next(0, 8);
                int newY = rand.Next(0, 8);
                int counter = 0;
                foreach (int item in playboard)
                {
                    if(item==3)
                    {
                        counter++;
                    }
                }
                if (counter < 1)
                {
                    return;
                }
                while (checkdirection(newX, newY) == false)
                {
                    newX = rand.Next(0, 8);
                    newY = rand.Next(0, 8);
                }
                move(newX, newY);
            }
        }

        int playerround = white;

        private void btnStart_Click(object sender, EventArgs e)
        {
            playboard = new int[,]
            {
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,1 ,2,0,0,0},

                {0,0,0,2 ,1,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
                {0,0,0,0 ,0,0,0,0},
            };
            round = white;
            drawBoard();
        }

        int inX = 0;
        int inY = 0;

        private void pBoard_MouseMove(object sender, MouseEventArgs e)
        {
            inX = Convert.ToInt32(Math.Floor(Convert.ToDouble(e.Y)/64));
            inY = Convert.ToInt32(Math.Floor(Convert.ToDouble(e.X) / 64));
            if(playboard[inX,inY]==valid)
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            computerMove();
            drawBoard();
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            if(mode==1)
            {
                computerMove();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Support.back(Parent, this);
            ((MainForm)Parent.Parent).label1.Text = "Players";
            this.Dispose();
        }

        private void Board_Enter(object sender, EventArgs e)
        {
            drawBoard();
        }

        private void btnPlayerChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? this will reset the game!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                round = white;
                playerround = (playerround == white) ? black : white;
                if (playerround == white)
                {
                    playerLabel.Text = "You play as WHITE!";
                }
                else if (playerround == black)
                {
                    playerLabel.Text = "You play as BLACK!";
                }
                btnStart.PerformClick();
                computerMove();
            }
        }
    }
}
