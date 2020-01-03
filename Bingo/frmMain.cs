using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Text;

namespace Bingo
{
    public partial class frmMain : Form
    {
        // Constants
        private const int BINGO_NUM_SPACING = 3;
        private const string BINGO = "BINGO";

        // Configuration Objects
        private ProgConfig progConfig;

        // Arrays to hold labels for the bingo numbers and cards
        private Label[,] BINGO_Numbers;
        private Label[,] BINGO_GameCard;

        // Private vars
        private int callCount = 0;
        private int gameCount = 0;
        private List<string> calledList = new List<string>();
        private frmCallHistory fCalledNumbers;
        private Advert advertCtrl = new Advert("Adverts");
        private BingoGame[] games;
        private Help.frmHelp fHelp;

        // Private Methods
        /// <summary>
        /// Create the grid to show called numbers
        /// </summary>
        private void loadBINGONumberGrid()
        {
            int nextNum = 1;

            for (int m = 0; m < 5; m++)
            {
                for (int n = 0; n < 16; n++)
                {
                    BINGO_Numbers[m, n] = new Label();
                    BINGO_Numbers[m, n].AutoSize = false;
                    BINGO_Numbers[m, n].TextAlign = ContentAlignment.MiddleCenter;
                    BINGO_Numbers[m, n].Font = new Font("Arial", 12, FontStyle.Bold);
                    BINGO_Numbers[m, n].BorderStyle = BorderStyle.Fixed3D;
                    if (n == 0)
                    {
                        BINGO_Numbers[m, n].BackColor = Color.Red;
                        BINGO_Numbers[m, n].ForeColor = Color.White;
                        BINGO_Numbers[m, n].Text = BINGO[m].ToString();
                    }
                    else
                    {
                        BINGO_Numbers[m, n].BackColor = Color.White;
                        BINGO_Numbers[m, n].ForeColor = Color.Black;
                        BINGO_Numbers[m, n].Text = nextNum.ToString();
                        nextNum++;
                    }
                    BINGO_Numbers[m, n].Click += new System.EventHandler(this.BINGO_Numbers_click);
                    panBingoNumbers.Controls.Add(BINGO_Numbers[m, n]);
                }
            }
        }

        /// <summary>
        /// Create the grid to show a sample game card for the current game
        /// </summary>
        private void loadGamecardGrid()
        {
            int nextNum = 1;

            for (int m = 0; m < 6; m++)
            {
                for (int n = 0; n < 5; n++)
                {
                    BINGO_GameCard[m, n] = new Label();
                    BINGO_GameCard[m, n].AutoSize = false;
                    BINGO_GameCard[m, n].TextAlign = ContentAlignment.MiddleCenter;
                    BINGO_GameCard[m, n].Font = new Font("Arial", 12, FontStyle.Bold);
                    BINGO_GameCard[m, n].BorderStyle = BorderStyle.Fixed3D;
                    if (m == 0)
                    {
                        BINGO_GameCard[m, n].BackColor = Color.Black;
                        BINGO_GameCard[m, n].ForeColor = Color.White;
                        BINGO_GameCard[m, n].Text = BINGO[n].ToString();
                    }
                    else
                    {
                        BINGO_GameCard[m, n].BackColor = Color.White;
                        nextNum++;
                    }
                    BINGO_GameCard[m, n].Click += new System.EventHandler(this.BINGO_Numbers_click);
                    panGameView.Controls.Add(BINGO_GameCard[m, n]);
                }
            }
        }

        // Initialize
        public frmMain()
        {
            InitializeComponent();

            progConfig = ProgConfig.LoadConfig();

            panBingoNumbers.Visible = true;
            panBottom.Visible = true;
            panAdvert.Visible = true;

            BINGO_Numbers = new Label[5, 16];
            BINGO_GameCard = new Label[6, 5];
        }

        // Event Handlers
        //Form Items
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (progConfig != null)
            {
                lblGameSetTitle.Text = progConfig.GameSetName;

                string[] gameStrings = progConfig.GamePatterns.Split(new char[] { '\r', '\n' });

                games = new BingoGame[gameStrings.Length];

                for (int i = 0; i < gameStrings.Length; i++)
                {
                    games[i] = new BingoGame();
                    if (games[i].FromString(gameStrings[i]))
                    {
                        lstGames.Items.Add(games[i]);
                    }
                }
            }

            panBottom.Height = (statusStrip1.Top - menuStrip1.Height) / 2;
            loadBINGONumberGrid();
            loadGamecardGrid();

            frmMain_Resize(null, null);

            // Fix problem of the advertCtrl going behind pictureBox1 1 of 2
            Control tempCtl = pictureBox1;
            panAdvert.Controls.Remove(tempCtl);
            // END: Fix problem of the advertCtrl going behind pictureBox1 1 of 2

            advertCtrl.Dock = DockStyle.Fill;
            advertCtrl.AdvertTime_ms = 10000;
            panAdvert.Controls.Add(advertCtrl);
            // Fix problem of the advertCtrl going behind pictureBox1 2 of 2
            panAdvert.Controls.Add(tempCtl);
            // END: Fix problem of the advertCtrl going behind pictureBox1 2 of 2

            if (lstGames.Items.Count > 0)
            {
                lstGames.SelectedIndex = 0;
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            // Split the available space in half top to bottom
            panBottom.Height = (panAdvert.Top - menuStrip1.Height) / 2;

            // Top BINGO Numbers
            float maxFontSize = 72;
            int w = (panBingoNumbers.Width - (panBingoNumbers.Padding.Left + panBingoNumbers.Padding.Right) - (15 * BINGO_NUM_SPACING)) / 16;
            int h = (panBingoNumbers.Height - (panBingoNumbers.Padding.Top + panBingoNumbers.Padding.Bottom) - (4 * BINGO_NUM_SPACING)) / 5;

            System.Drawing.Graphics g = this.CreateGraphics();
            Font stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
            SizeF stringSize = new SizeF();
            stringSize = g.MeasureString("WW", stringFont);

            while (stringSize.Width > w || stringSize.Height > h)
            {
                maxFontSize = maxFontSize - 1;
                stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
                stringSize = g.MeasureString("WW", stringFont);
            }

            for (int m = 0; m < 5; m++)
            {
                for (int n = 0; n < 16; n++)
                {
                    BINGO_Numbers[m, n].Font = new Font("Arial", maxFontSize, FontStyle.Bold);

                    BINGO_Numbers[m, n].Size = new System.Drawing.Size(w, h);
                    BINGO_Numbers[m, n].Left = n * (w + BINGO_NUM_SPACING);
                    BINGO_Numbers[m, n].Top = m * (h + BINGO_NUM_SPACING);
                }
            }

            // Bottom Panels
            panCallCount.Width = panBottom.Width / 6;
            panGameCount.Width = panCallCount.Width;
            panGameView.Width = panBottom.Width / 3;

            maxFontSize = 72;
            stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
            stringSize = g.MeasureString("GAME COUNT", stringFont);

            while (stringSize.Width > lblCallCount.Width || stringSize.Height > lblCallCount.Height)
            {
                maxFontSize = maxFontSize - 1;
                stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
                stringSize = g.MeasureString("GAME COUNT", stringFont);
            }
            lblCallCount.Font = new Font("Arial", maxFontSize, FontStyle.Bold);
            lblGameCount.Font = new Font("Arial", maxFontSize, FontStyle.Bold);
            lblLastCalled.Font = new Font("Arial", maxFontSize, FontStyle.Bold);

            // Bottom Labels
            int botSpace = 10;
            lblCallCountValue.Left = botSpace;
            lblGameCountValue.Left = botSpace;
            lblLastCalledValue.Left = botSpace;

            lblCallCountValue.Width = panCallCount.Width - (botSpace * 2);
            lblGameCountValue.Width = panGameCount.Width - (botSpace * 2);
            lblLastCalledValue.Width = panLastNumber.Width - (botSpace * 2);

            lblCallCountValue.Top = lblCallCount.Height + botSpace;
            lblGameCountValue.Top = lblGameCount.Height + botSpace;
            lblLastCalledValue.Top = lblLastCalled.Height + botSpace;

            if ((lblCallCountValue.Width * 3) / 2 < panCallCount.Height - lblCallCount.Height - (botSpace * 2))
            {
                h = (lblCallCountValue.Width * 3) / 2;
            }
            else
            {
                h = panCallCount.Height - lblCallCount.Height - (botSpace * 2);
            }

            lblCallCountValue.Height = h;
            lblGameCountValue.Height = h;
            lblLastCalledValue.Height = h;

            maxFontSize = 200;
            stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
            stringSize = g.MeasureString("WW", stringFont);

            while (stringSize.Width > lblCallCountValue.Width || stringSize.Height > lblCallCountValue.Height)
            {
                maxFontSize = maxFontSize - 1;
                stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
                stringSize = g.MeasureString("WW", stringFont);
            }
            lblCallCountValue.Font = new Font("Arial", maxFontSize, FontStyle.Bold);
            lblGameCountValue.Font = new Font("Arial", maxFontSize, FontStyle.Bold);

            maxFontSize = 200;
            stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
            stringSize = g.MeasureString("WWW", stringFont, lblLastCalledValue.Width);

            while (stringSize.Width > lblLastCalledValue.Width || stringSize.Height > lblLastCalledValue.Height)
            {
                maxFontSize = maxFontSize - 1;
                stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
                stringSize = g.MeasureString("WWW", stringFont, lblLastCalledValue.Width);
            }
            lblLastCalledValue.Font = new Font("Arial", maxFontSize, FontStyle.Bold);

            // Game View
            w = (panGameView.Width - (panGameView.Padding.Left + panGameView.Padding.Right) - (4 * BINGO_NUM_SPACING)) / 5;
            h = (panGameView.Height - panNewGame.Height - (panGameView.Padding.Top + panGameView.Padding.Bottom) - (5 * BINGO_NUM_SPACING)- 10) / 6;

            if (h > w) { h = w; }
            else if (w > h) { w = h; }
            int lp = (panGameView.Width - (panGameView.Padding.Left + panGameView.Padding.Right) - (4 * BINGO_NUM_SPACING) - (5 * w))/2;

            maxFontSize = 72;
            stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
            stringSize = g.MeasureString("WW", stringFont);
            while (stringSize.Width > w || stringSize.Height > h)
            {
                maxFontSize = maxFontSize - 1;
                stringFont = new Font("Arial", maxFontSize, FontStyle.Bold);
                stringSize = g.MeasureString("WW", stringFont);
            }

            for (int m = 0; m < 6; m++)
            {
                for (int n = 0; n < 5; n++)
                {
                    BINGO_GameCard[m, n].Font = new Font("Arial", maxFontSize, FontStyle.Bold);

                    BINGO_GameCard[m, n].Size = new System.Drawing.Size(w, h);
                    BINGO_GameCard[m, n].Left = n * (w + BINGO_NUM_SPACING) + lp;
                    BINGO_GameCard[m, n].Top = panNewGame.Height + (m * (h + BINGO_NUM_SPACING));
                }
            }
        }

        // Menu Items
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox about = new frmAboutBox();

            about.ShowDialog();

            about.Dispose();
        }

        private void editGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (progConfig == null)
            {
                progConfig = new ProgConfig();
                progConfig.GameSetName = lblGameSetTitle.Text;
            }

            if (progConfig != null)
            {
                frmGameEditor newGame = new frmGameEditor(games, progConfig.GameSetName);
                newGame.ShowDialog();
                games = newGame.Games;

                StringBuilder games2Str = new StringBuilder("");
                if (games != null && games.Length > 0) 
                {
                    for (int i = 0; i < games.Length; i++)
                    {
                        if (games[i] != null)
                        {
                            if (i > 0) { games2Str.AppendLine(); }
                            games2Str.Append(games[i].ToString());
                        }
                    }
                }

                progConfig.GameSetName = newGame.GameSetTitle;
                progConfig.GamePatterns = games2Str.ToString();
                progConfig.SaveConfig();
                newGame = null;

                lblGameSetTitle.Text = progConfig.GameSetName;
                lstGames.Items.Clear();
                for (int n = 0; n < games.Length; n++)
                {
                    lstGames.Items.Add(games[n]);
                }
            }
            else
            {
                MessageBox.Show(this, "Error Could not save configuration\r\n\r\n" +
                    "You may not have permision to write to the directory or the file may be in use.", "Error Saving Game Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Other  controls
        /// <summary>
        /// Change the background color of the label clicked in the called numbers tracker or the sample card
        /// In addition these actions take place for the numbers in the called numbers tracking grid
        /// - If a number is selected
        ///     · Call count increases by one
        ///     · The letter & number are stored in the called stack
        ///     · Last Called letter & number is displayed
        /// - If a number is unselected
        ///     · Call count decreases by one
        ///     · The letter & number are removed from the called stack
        ///     · The Last Called letter & number are updated if necessary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BINGO_Numbers_click(object sender, EventArgs e)
        {
            Label bingoNumLabel = (Label)sender;
            string parentName = ((Control)sender).Parent.Name;
            string letterNumber = bingoNumLabel.Text;
            int num = 0;
            int bingIdx = 0;

            if (int.TryParse(letterNumber, out num))
            {
                bingIdx = (num - 1) / 15;
                letterNumber = BINGO[bingIdx].ToString() + " " + letterNumber;
            }

            if (bingoNumLabel.BackColor == Color.White)
            {
                bingoNumLabel.BackColor = Color.Blue;
                bingoNumLabel.ForeColor = Color.White;
                if (parentName == panBingoNumbers.Name)
                {
                    callCount++;
                    calledList.Add(letterNumber);
                }
            }
            else if (bingoNumLabel.BackColor == Color.Blue)
            {
                bingoNumLabel.BackColor = Color.White;
                bingoNumLabel.ForeColor = Color.Black;
                if (parentName == panBingoNumbers.Name)
                {
                    callCount--;
                    calledList.Remove(letterNumber);
                }
            }
            if (fCalledNumbers != null && !fCalledNumbers.Disposing)
            {
                fCalledNumbers.CalledList = calledList;
            }


            if (gameCount == 0 && callCount > 0)
            {
                gameCount++;
                lblGameCountValue.Text = gameCount.ToString();
            }

            if (parentName == panBingoNumbers.Name)
            {
                lblCallCountValue.Text = callCount.ToString();
                lblLastCalledValue.Text = (calledList.Count != 0) ? calledList[calledList.Count - 1] : "";
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (callCount > 0)
            {
                DialogResult q = MessageBox.Show(this, "- Click \"Yes\" to clear the board and start a new game.\n" +
                    "- Click \"No\" to clear the board and continue current game\n" +
                    "- Click \"Cancel\" to cancel and return to the current game", "Confirm: Start New Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (q == DialogResult.Yes)
                {
                    gameCount++;
                    lblGameCountValue.Text = gameCount.ToString();
                    calledList.Clear();
                    lblLastCalledValue.Text = "";

                    if (fCalledNumbers != null && !fCalledNumbers.Disposing)
                    {
                        fCalledNumbers.CalledList = calledList;
                    }
                }
                if (q == DialogResult.Yes || q == DialogResult.No)
                {
                    for (int y = 0; y < 16; y++)
                    {
                        for (int x = 0; x < 5; x++)
                        {
                            if (BINGO_Numbers[x, y].BackColor == Color.Blue)
                            {
                                BINGO_Numbers[x, y].BackColor = Color.White;
                                BINGO_Numbers[x, y].ForeColor = Color.Black;
                            }
                        }
                    }
                    callCount = 0;
                    lblCallCountValue.Text = callCount.ToString();
                }
            }
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            BingoGame selGame = (BingoGame)lstGames.SelectedItem;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (selGame.Card[x, y])
                    {
                        BINGO_GameCard[y + 1, x].BackColor = Color.Blue;
                        BINGO_GameCard[y + 1,x].ForeColor = Color.White;
                    }
                    else
                    {
                        BINGO_GameCard[y + 1, x].BackColor = Color.White;
                        BINGO_GameCard[y + 1, x].ForeColor = Color.Black;
                    }
                }
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fHelp != null && !fHelp.IsDisposed)
            {
                fHelp.Show();
                fHelp.WindowState = fHelp.LastWindowState;
            }
            else
            {
                fHelp = new Help.frmHelp();
                fHelp.Show();
            }
        }

        private void callWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCalledNumbers != null && !fCalledNumbers.IsDisposed)
            {
                fCalledNumbers.Show();
                fCalledNumbers.WindowState = fCalledNumbers.LastWindowState;
            }
            else
            {
                fCalledNumbers = new frmCallHistory();
                fCalledNumbers.Show();
                fCalledNumbers.CalledList = calledList;
            }
        }

    }
}