using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Co_Caro
{
    public partial class Form1 : Form
    {
        private Label[,] Map;
        private static int columns, rows;

        private int player;
        private bool gameover;
        private int[,] vtMap;
        private Stack<Chess> chesses;
        private Chess chess;

        public Form1()
        {
            columns = 20;
            rows = 18;
            gameover = false;
            player = 1;
            Map = new Label[rows + 2, columns + 2];
            vtMap = new int[rows + 2, columns + 2];
            chesses = new Stack<Chess>();
            InitializeComponent();

            BuildTable();
        }

        private void BuildTable()
        {
            for (int i = 2; i <= rows; i++)
                for (int j = 1; j <= columns; j++)
                {
                    Map[i, j] = new Label();
                    Map[i, j].Parent = pnTableChess;
                    Map[i, j].Top = i * Contain.edgeChess;
                    Map[i, j].Left = j * Contain.edgeChess;
                    Map[i, j].Size = new Size(Contain.edgeChess - 1, Contain.edgeChess - 1);
                    Map[i, j].BackColor = Color.Snow;
                    Map[i, j].Click += Form1_Click;
                }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (gameover)
                return;
            Label lb = (Label)sender;
            int x = lb.Top / Contain.edgeChess - 1, y = lb.Left / Contain.edgeChess;
            if (vtMap[x, y] != 0)
                return;

            else
            {
                if (player == 1)
                {
                    psbCooldownTime.Value = 0;
                    tmCooldown.Start();
                    lb.Image = Properties.Resources.o;
                    vtMap[x, y] = 1;
                    Check(x, y);

                    player = 2;
                    ptbPayer.Image = Properties.Resources.x_copy;
                    txtNamePlayer.Text = "Player 2";
                }
                else
                {
                    psbCooldownTime.Value = 0;
                    lb.Image = Properties.Resources.x;
                    vtMap[x, y] = 2;
                    Check(x, y);
                    player = 1;
                    ptbPayer.Image = Properties.Resources.onnnn;
                    txtNamePlayer.Text = "Player 1";
                }
            }
            chess = new Chess(lb, x, y);
            chesses.Push(chess);
        }

        private void tmCooldown_Tick(object sender, EventArgs e)
        {
            psbCooldownTime.PerformStep();
            if (psbCooldownTime.Value >= psbCooldownTime.Maximum)
            {
                Gameover();
            }
        }

        private void menuQuit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void player1VsPlayer2(object sender, EventArgs e)
        {
            gameover = false;
            psbCooldownTime.Value = 0;
            tmCooldown.Stop();
            pnTableChess.Controls.Clear();

            txtNamePlayer.Text = "";
            ptbPayer.Image = null;
            menuStrip1.Parent = pnTableChess;
            player = 1;
            Map = new Label[rows + 2, columns + 2];
            vtMap = new int[rows + 2, columns + 2];
            chesses = new Stack<Chess>();

            BuildTable();
        }

        private void Gameover()
        {
            tmCooldown.Stop();
            gameover = true;
            backgroundgameover();
        }
        private void backgroundgameover()
        {
            for (int i = 2; i <= rows; i++)
                for (int j = 1; j <= columns; j++)
                {
                    Map[i, j].BackColor = Color.Gray;
                }
        }

        private void ChangePlayer()
        {
            if (player == 1)
            {
                player = 2;
                txtNamePlayer.Text = "Player 2";
                ptbPayer.Image = Properties.Resources.x_copy;
            }
            else
            {
                player = 1;
                txtNamePlayer.Text = "Player 1";
                ptbPayer.Image = Properties.Resources.onnnn;
            }
        }

        private void Check(int x, int y)
        {
            int i = x - 1, j = y;
            int column = 1, row = 1, mdiagonal = 1, ediagonal = 1;
            while (vtMap[x, y] == vtMap[i, j] && i >= 0)
            {
                column++;
                i--;
            }
            i = x + 1;
            while (vtMap[x, y] == vtMap[i, j] && i <= rows)
            {
                column++;
                i++;
            }
            i = x; j = y - 1;
            while (vtMap[x, y] == vtMap[i, j] && j >= 0)
            {
                row++;
                j--;
            }
            j = y + 1;
            while (vtMap[x, y] == vtMap[i, j] && j <= columns)
            {
                row++;
                j++;
            }
            i = x - 1; j = y - 1;
            while (vtMap[x, y] == vtMap[i, j] && i >= 0 && j >= 0)
            {
                mdiagonal++;
                i--;
                j--;
            }
            i = x + 1; j = y + 1;
            while (vtMap[x, y] == vtMap[i, j] && i <= rows && j <= columns)
            {
                mdiagonal++;
                i++;
                j++;
            }
            i = x - 1; j = y + 1;
            while (vtMap[x, y] == vtMap[i, j] && i >= 0 && j <= columns)
            {
                ediagonal++;
                i--;
                j++;
            }
            i = x + 1; j = y - 1;
            while (vtMap[x, y] == vtMap[i, j] && i <= rows && j >= 0)
            {
                ediagonal++;
                i++;
                j--;
            }
            if (row >= 5 || column >= 5 || mdiagonal >= 5 || ediagonal >= 5)
            {
                Gameover();
                 {
                    if (player == 1)
                        MessageBox.Show("Player 1 Win");
                    else
                        MessageBox.Show("Player 2 Win");
                }
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnTableChess_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuNewGame_Click(object sender, EventArgs e)
        {

        }

        public class Chess
        {
            public Label lb;
            public int X;
            public int Y;
            public Chess()
            {
                lb = new Label();
            }
            public Chess(Label _lb, int x, int y)
            {
                lb = new Label();
                lb = _lb;
                X = x;
                Y = y;
            }
        }
    }
}
