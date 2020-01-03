using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bingo
{
    public partial class frmGameEditor : Form
    {
        private BingoGame[] games;
        private string gameSetTitle;

        private const int BINGO_NUM_SPACING = 3;
        private const string BINGO = "BINGO";

        private BingoGame currentGame;
        private Label[,] BINGO_GameCard;

        // Properties
        public BingoGame[] Games
        {
            get { return games; }
        }

        public string GameSetTitle
        {
            get { return gameSetTitle; }
        }


        // Private Methods
        private void loadGamecardGrid()
        {
            int nextNum = 1;

            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    BINGO_GameCard[x, y] = new Label();
                    BINGO_GameCard[x, y].AutoSize = false;
                    BINGO_GameCard[x, y].TextAlign = ContentAlignment.MiddleCenter;
                    BINGO_GameCard[x, y].Font = new Font("Arial", 12, FontStyle.Bold);
                    BINGO_GameCard[x, y].BorderStyle = BorderStyle.Fixed3D;
                    if (y == 0)
                    {
                        BINGO_GameCard[x, y].BackColor = Color.Black;
                        BINGO_GameCard[x, y].ForeColor = Color.White;
                        BINGO_GameCard[x, y].Text = BINGO[x].ToString();
                    }
                    else
                    {
                        BINGO_GameCard[x, y].BackColor = Color.White;
                        nextNum++;
                    }
                    BINGO_GameCard[x, y].Click += new System.EventHandler(this.BINGO_Numbers_click);
                    panCard.Controls.Add(BINGO_GameCard[x, y]);
                }
            }
        }

        // Event Handlers
        private void BINGO_Numbers_click(object sender, EventArgs e)
        {
            Label bingoNumLabel = (Label)sender;

            if (bingoNumLabel.BackColor == Color.White)
            {
                bingoNumLabel.BackColor = Color.Blue;
                bingoNumLabel.ForeColor = Color.White;
            }
            else if (bingoNumLabel.BackColor == Color.Blue)
            {
                bingoNumLabel.BackColor = Color.White;
                bingoNumLabel.ForeColor = Color.Black;
            }
        }


        // Initialize
        public frmGameEditor(BingoGame[] Games, string GameSetTitle)
        {
            InitializeComponent();

            games = Games;

            gameSetTitle = GameSetTitle;

            if (games != null)
            {
                for (int i = 0; i < games.Length; i++)
                {
                    if (games[i] != null)
                    {
                        lstGames.Items.Add(games[i]);
                    }
                }
            }

            //panGameTitle.Visible = false;
            //panCard.Visible = false;
            //panCardButtons.Visible = false;

            BINGO_GameCard = new Label[5, 6];
        }

        private void frmGameEditor_Load(object sender, EventArgs e)
        {
            txtGameSetTitle.Text = gameSetTitle;

            loadGamecardGrid();

            frmGameEditor_Resize(null, null);

            if (lstGames.Items.Count > 0)
            {
                lstGames.SelectedIndex = 0;
            }

            this.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            notifyGameSetTitle.ShowBalloonTip(3000);
        }

        private void frmGameEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameSetTitle = txtGameSetTitle.Text;

            games = new BingoGame[lstGames.Items.Count];

            for (int i = 0; i < lstGames.Items.Count; i++)
            {
                games[i] = (BingoGame)lstGames.Items[i];
            }
        }

        private void frmGameEditor_Resize(object sender, EventArgs e)
        {
            // OK Button
            cmdOK.Left = (panButtons.Width - cmdOK.Width) / 2;
            cmdOK.Top = (panButtons.Height - cmdOK.Height) / 2;

            // Game Buttons
            cmdSave.Left = (panCardButtons.Width - cmdSave.Width - 10 - cmdCancel.Width) / 2;
            cmdSave.Top = (panCardButtons.Height - cmdSave.Height) / 2;
            cmdCancel.Left = cmdSave.Left + cmdSave.Width + 10;
            cmdCancel.Top = cmdSave.Top;

            // Game View
            System.Drawing.Graphics g = this.CreateGraphics();

            int w = (panCard.Width - (panCard.Padding.Left + panCard.Padding.Right) - (4 * BINGO_NUM_SPACING)) / 5;
            int h = (panCard.Height - (panCard.Padding.Top + panCard.Padding.Bottom) - (5 * BINGO_NUM_SPACING)) / 6;

            if (h > w) { h = w; }

            float maxFontSize = 72;
            Font stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
            SizeF stringSize = g.MeasureString("W", stringFont);
            while (stringSize.Width > w || stringSize.Height > h)
            {
                maxFontSize = maxFontSize - 1;
                stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
                stringSize = g.MeasureString("W", stringFont);
            }

            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    BINGO_GameCard[x, y].Font = new Font("Arial", maxFontSize, FontStyle.Bold);

                    BINGO_GameCard[x, y].Size = new System.Drawing.Size(w, h);
                    BINGO_GameCard[x, y].Left = x * (w + BINGO_NUM_SPACING);
                    BINGO_GameCard[x, y].Top = (y * (h + BINGO_NUM_SPACING));
                }
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            currentGame = new BingoGame();

            currentGame.Name = (lstGames.Items.Count + 1).ToString() + ". New Game";
            currentGame.Order = lstGames.Items.Count;
            lstGames.Items.Add(currentGame);
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex < 0)
            {
                txtGameTitle.Text = "";

                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        BINGO_GameCard[x, y + 1].BackColor = Color.White;
                    }
                }

                return;
            }

            currentGame = (BingoGame)lstGames.Items[lstGames.SelectedIndex];
            txtGameTitle.Text = currentGame.Name;

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if(currentGame.Card[x,y])
                        BINGO_GameCard[x, y + 1].BackColor = Color.Blue;
                    else
                        BINGO_GameCard[x, y + 1].BackColor = Color.White;
                }
            }

            panGameTitle.Visible = true;
            panCard.Visible = true;
            panCardButtons.Visible = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            int curIdx = lstGames.SelectedIndex;
            currentGame = (BingoGame)lstGames.Items[lstGames.SelectedIndex];

            currentGame.Name = txtGameTitle.Text;

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (BINGO_GameCard[x, y + 1].BackColor == Color.Blue)
                        currentGame.Card[x, y] = true;
                    else
                        currentGame.Card[x, y] = false;
                }
            }
            lstGames.Items[curIdx] = currentGame;
            lstGames.SelectedIndex = curIdx;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex > -1)
                lstGames.Items.RemoveAt(lstGames.SelectedIndex);
        }

        private void cmdMoveUp_Click(object sender, EventArgs e)
        {
            int curLoc = lstGames.SelectedIndex;

            if (curLoc <= 0)
                return;

            BingoGame item2move = (BingoGame)lstGames.Items[lstGames.SelectedIndex];

            lstGames.Items.RemoveAt(curLoc);
            lstGames.Items.Insert(curLoc - 1, item2move);
            lstGames.SelectedIndex = curLoc - 1;
        }

        private void cmdMoveDown_Click(object sender, EventArgs e)
        {
            int curLoc = lstGames.SelectedIndex;

            if (curLoc >= lstGames.Items.Count - 1 || curLoc < 0)
                return;

            BingoGame item2move = (BingoGame)lstGames.Items[lstGames.SelectedIndex];

            lstGames.Items.RemoveAt(curLoc);
            lstGames.Items.Insert(curLoc + 1, item2move);
            lstGames.SelectedIndex = curLoc + 1;
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            int curLoc = lstGames.SelectedIndex;

            if (curLoc > -1)
            {
                BingoGame item2copy = (BingoGame)lstGames.Items[lstGames.SelectedIndex];
                BingoGame item2Add = new BingoGame();

                item2Add.Name = item2copy.Name + " (Copy)";
                item2Add.Card = item2copy.Card;
                item2Add.Order = item2copy.Order;
                item2Add.Played = false;

                lstGames.Items.Add(item2Add);
                lstGames.SelectedIndex = lstGames.Items.Count - 1;
            }
        }
    }
}
