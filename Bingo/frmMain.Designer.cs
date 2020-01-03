namespace Bingo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblGameSetTitle = new System.Windows.Forms.Label();
            this.panAdvert = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panBottom = new System.Windows.Forms.Panel();
            this.panLastNumber = new System.Windows.Forms.Panel();
            this.lblLastCalledValue = new System.Windows.Forms.Label();
            this.lblLastCalled = new System.Windows.Forms.Label();
            this.panGameCount = new System.Windows.Forms.Panel();
            this.lblGameCountValue = new System.Windows.Forms.Label();
            this.lblGameCount = new System.Windows.Forms.Label();
            this.panCallCount = new System.Windows.Forms.Panel();
            this.lblCallCountValue = new System.Windows.Forms.Label();
            this.lblCallCount = new System.Windows.Forms.Label();
            this.panGameView = new System.Windows.Forms.Panel();
            this.panNewGame = new System.Windows.Forms.Panel();
            this.lstGames = new System.Windows.Forms.ComboBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.panBingoNumbers = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panAdvert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panBottom.SuspendLayout();
            this.panLastNumber.SuspendLayout();
            this.panGameCount.SuspendLayout();
            this.panCallCount.SuspendLayout();
            this.panGameView.SuspendLayout();
            this.panNewGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameSetToolStripMenuItem,
            this.openGameSetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameSetToolStripMenuItem
            // 
            this.newGameSetToolStripMenuItem.Name = "newGameSetToolStripMenuItem";
            this.newGameSetToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newGameSetToolStripMenuItem.Text = "&New Game Set";
            this.newGameSetToolStripMenuItem.Visible = false;
            // 
            // openGameSetToolStripMenuItem
            // 
            this.openGameSetToolStripMenuItem.Name = "openGameSetToolStripMenuItem";
            this.openGameSetToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openGameSetToolStripMenuItem.Text = "&Open Game Set";
            this.openGameSetToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            this.toolStripMenuItem1.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGamesToolStripMenuItem,
            this.toolStripMenuItem2});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // editGamesToolStripMenuItem
            // 
            this.editGamesToolStripMenuItem.Name = "editGamesToolStripMenuItem";
            this.editGamesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editGamesToolStripMenuItem.Text = "&Edit Games";
            this.editGamesToolStripMenuItem.Click += new System.EventHandler(this.editGamesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
            this.toolStripMenuItem2.Visible = false;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callWindowToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // callWindowToolStripMenuItem
            // 
            this.callWindowToolStripMenuItem.Name = "callWindowToolStripMenuItem";
            this.callWindowToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.callWindowToolStripMenuItem.Text = "&Call Window";
            this.callWindowToolStripMenuItem.Click += new System.EventHandler(this.callWindowToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "&View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblGameSetTitle
            // 
            this.lblGameSetTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGameSetTitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameSetTitle.Location = new System.Drawing.Point(0, 24);
            this.lblGameSetTitle.Name = "lblGameSetTitle";
            this.lblGameSetTitle.Size = new System.Drawing.Size(624, 47);
            this.lblGameSetTitle.TabIndex = 2;
            this.lblGameSetTitle.Text = "BINGO";
            this.lblGameSetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panAdvert
            // 
            this.panAdvert.Controls.Add(this.pictureBox1);
            this.panAdvert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panAdvert.Location = new System.Drawing.Point(0, 345);
            this.panAdvert.Name = "panAdvert";
            this.panAdvert.Size = new System.Drawing.Size(624, 75);
            this.panAdvert.TabIndex = 6;
            this.panAdvert.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Bingo.Properties.Resources.TeelSys_Logo_sm_t;
            this.pictureBox1.Location = new System.Drawing.Point(529, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.panLastNumber);
            this.panBottom.Controls.Add(this.panGameCount);
            this.panBottom.Controls.Add(this.panCallCount);
            this.panBottom.Controls.Add(this.panGameView);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 183);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(624, 162);
            this.panBottom.TabIndex = 7;
            this.panBottom.Visible = false;
            // 
            // panLastNumber
            // 
            this.panLastNumber.Controls.Add(this.lblLastCalledValue);
            this.panLastNumber.Controls.Add(this.lblLastCalled);
            this.panLastNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLastNumber.Location = new System.Drawing.Point(240, 0);
            this.panLastNumber.Name = "panLastNumber";
            this.panLastNumber.Padding = new System.Windows.Forms.Padding(5);
            this.panLastNumber.Size = new System.Drawing.Size(241, 162);
            this.panLastNumber.TabIndex = 7;
            // 
            // lblLastCalledValue
            // 
            this.lblLastCalledValue.BackColor = System.Drawing.Color.White;
            this.lblLastCalledValue.Location = new System.Drawing.Point(3, 56);
            this.lblLastCalledValue.Name = "lblLastCalledValue";
            this.lblLastCalledValue.Size = new System.Drawing.Size(110, 89);
            this.lblLastCalledValue.TabIndex = 2;
            this.lblLastCalledValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastCalled
            // 
            this.lblLastCalled.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastCalled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCalled.Location = new System.Drawing.Point(5, 5);
            this.lblLastCalled.Name = "lblLastCalled";
            this.lblLastCalled.Size = new System.Drawing.Size(231, 25);
            this.lblLastCalled.TabIndex = 0;
            this.lblLastCalled.Text = "Last Called";
            this.lblLastCalled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGameCount
            // 
            this.panGameCount.Controls.Add(this.lblGameCountValue);
            this.panGameCount.Controls.Add(this.lblGameCount);
            this.panGameCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.panGameCount.Location = new System.Drawing.Point(120, 0);
            this.panGameCount.Name = "panGameCount";
            this.panGameCount.Padding = new System.Windows.Forms.Padding(5);
            this.panGameCount.Size = new System.Drawing.Size(120, 162);
            this.panGameCount.TabIndex = 6;
            // 
            // lblGameCountValue
            // 
            this.lblGameCountValue.BackColor = System.Drawing.Color.Blue;
            this.lblGameCountValue.ForeColor = System.Drawing.Color.White;
            this.lblGameCountValue.Location = new System.Drawing.Point(3, 56);
            this.lblGameCountValue.Name = "lblGameCountValue";
            this.lblGameCountValue.Size = new System.Drawing.Size(110, 89);
            this.lblGameCountValue.TabIndex = 2;
            this.lblGameCountValue.Text = "0";
            this.lblGameCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameCount
            // 
            this.lblGameCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGameCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameCount.Location = new System.Drawing.Point(5, 5);
            this.lblGameCount.Name = "lblGameCount";
            this.lblGameCount.Size = new System.Drawing.Size(110, 25);
            this.lblGameCount.TabIndex = 0;
            this.lblGameCount.Text = "Game Count";
            this.lblGameCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCallCount
            // 
            this.panCallCount.Controls.Add(this.lblCallCountValue);
            this.panCallCount.Controls.Add(this.lblCallCount);
            this.panCallCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.panCallCount.Location = new System.Drawing.Point(0, 0);
            this.panCallCount.Name = "panCallCount";
            this.panCallCount.Padding = new System.Windows.Forms.Padding(5);
            this.panCallCount.Size = new System.Drawing.Size(120, 162);
            this.panCallCount.TabIndex = 5;
            // 
            // lblCallCountValue
            // 
            this.lblCallCountValue.BackColor = System.Drawing.Color.Blue;
            this.lblCallCountValue.ForeColor = System.Drawing.Color.White;
            this.lblCallCountValue.Location = new System.Drawing.Point(3, 56);
            this.lblCallCountValue.Name = "lblCallCountValue";
            this.lblCallCountValue.Size = new System.Drawing.Size(110, 89);
            this.lblCallCountValue.TabIndex = 1;
            this.lblCallCountValue.Text = "0";
            this.lblCallCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCallCount
            // 
            this.lblCallCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCallCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallCount.Location = new System.Drawing.Point(5, 5);
            this.lblCallCount.Name = "lblCallCount";
            this.lblCallCount.Size = new System.Drawing.Size(110, 25);
            this.lblCallCount.TabIndex = 0;
            this.lblCallCount.Text = "Call Count";
            this.lblCallCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGameView
            // 
            this.panGameView.Controls.Add(this.panNewGame);
            this.panGameView.Dock = System.Windows.Forms.DockStyle.Right;
            this.panGameView.Location = new System.Drawing.Point(481, 0);
            this.panGameView.Name = "panGameView";
            this.panGameView.Size = new System.Drawing.Size(143, 162);
            this.panGameView.TabIndex = 4;
            // 
            // panNewGame
            // 
            this.panNewGame.Controls.Add(this.lstGames);
            this.panNewGame.Controls.Add(this.cmdStart);
            this.panNewGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.panNewGame.Location = new System.Drawing.Point(0, 0);
            this.panNewGame.Name = "panNewGame";
            this.panNewGame.Size = new System.Drawing.Size(143, 30);
            this.panNewGame.TabIndex = 0;
            // 
            // lstGames
            // 
            this.lstGames.DisplayMember = "Name";
            this.lstGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(0, 0);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(104, 24);
            this.lstGames.TabIndex = 5;
            this.lstGames.SelectedIndexChanged += new System.EventHandler(this.lstGames_SelectedIndexChanged);
            // 
            // cmdStart
            // 
            this.cmdStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdStart.Location = new System.Drawing.Point(104, 0);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(39, 30);
            this.cmdStart.TabIndex = 4;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // panBingoNumbers
            // 
            this.panBingoNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBingoNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBingoNumbers.Location = new System.Drawing.Point(0, 71);
            this.panBingoNumbers.Name = "panBingoNumbers";
            this.panBingoNumbers.Size = new System.Drawing.Size(624, 112);
            this.panBingoNumbers.TabIndex = 8;
            this.panBingoNumbers.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bingo Game Set (*.bingo)|*.bingo";
            this.saveFileDialog1.Title = "Create New Game Set File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bingo Game Set (*.bingo)|*.bingo";
            this.openFileDialog1.Title = "Open Game Set File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.panBingoNumbers);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panAdvert);
            this.Controls.Add(this.lblGameSetTitle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "BINGO";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panAdvert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.panLastNumber.ResumeLayout(false);
            this.panGameCount.ResumeLayout(false);
            this.panCallCount.ResumeLayout(false);
            this.panGameView.ResumeLayout(false);
            this.panNewGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblGameSetTitle;
        private System.Windows.Forms.Panel panAdvert;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Panel panLastNumber;
        private System.Windows.Forms.Label lblLastCalled;
        private System.Windows.Forms.Panel panGameCount;
        private System.Windows.Forms.Label lblGameCount;
        private System.Windows.Forms.Panel panCallCount;
        private System.Windows.Forms.Label lblCallCount;
        private System.Windows.Forms.Panel panGameView;
        private System.Windows.Forms.Panel panBingoNumbers;
        private System.Windows.Forms.Label lblLastCalledValue;
        private System.Windows.Forms.Label lblGameCountValue;
        private System.Windows.Forms.Label lblCallCountValue;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panNewGame;
        private System.Windows.Forms.ComboBox lstGames;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}

