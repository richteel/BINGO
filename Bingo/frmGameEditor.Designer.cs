namespace Bingo
{
    partial class frmGameEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameEditor));
            this.panGameSetTitle = new System.Windows.Forms.Panel();
            this.txtGameSetTitle = new System.Windows.Forms.TextBox();
            this.picInfoGameSetTitle = new System.Windows.Forms.PictureBox();
            this.lblGameSetTitle = new System.Windows.Forms.Label();
            this.notifyGameSetTitle = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTipGameSet = new System.Windows.Forms.ToolTip(this.components);
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdMoveUp = new System.Windows.Forms.Button();
            this.cmdMoveDown = new System.Windows.Forms.Button();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.picInfoGameTitle = new System.Windows.Forms.PictureBox();
            this.panButtons = new System.Windows.Forms.Panel();
            this.cmdOK = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstGames = new System.Windows.Forms.ListBox();
            this.panGamesButtons = new System.Windows.Forms.Panel();
            this.lblGames = new System.Windows.Forms.Label();
            this.panCard = new System.Windows.Forms.Panel();
            this.panCardButtons = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panGameTitle = new System.Windows.Forms.Panel();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.panGameSetTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoGameSetTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoGameTitle)).BeginInit();
            this.panButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panGamesButtons.SuspendLayout();
            this.panCardButtons.SuspendLayout();
            this.panGameTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGameSetTitle
            // 
            this.panGameSetTitle.Controls.Add(this.txtGameSetTitle);
            this.panGameSetTitle.Controls.Add(this.picInfoGameSetTitle);
            this.panGameSetTitle.Controls.Add(this.lblGameSetTitle);
            this.panGameSetTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGameSetTitle.Location = new System.Drawing.Point(0, 0);
            this.panGameSetTitle.Name = "panGameSetTitle";
            this.panGameSetTitle.Padding = new System.Windows.Forms.Padding(3);
            this.panGameSetTitle.Size = new System.Drawing.Size(624, 26);
            this.panGameSetTitle.TabIndex = 0;
            // 
            // txtGameSetTitle
            // 
            this.txtGameSetTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGameSetTitle.Location = new System.Drawing.Point(92, 3);
            this.txtGameSetTitle.Name = "txtGameSetTitle";
            this.txtGameSetTitle.Size = new System.Drawing.Size(507, 20);
            this.txtGameSetTitle.TabIndex = 2;
            // 
            // picInfoGameSetTitle
            // 
            this.picInfoGameSetTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.picInfoGameSetTitle.Image = ((System.Drawing.Image)(resources.GetObject("picInfoGameSetTitle.Image")));
            this.picInfoGameSetTitle.Location = new System.Drawing.Point(599, 3);
            this.picInfoGameSetTitle.Name = "picInfoGameSetTitle";
            this.picInfoGameSetTitle.Size = new System.Drawing.Size(22, 20);
            this.picInfoGameSetTitle.TabIndex = 1;
            this.picInfoGameSetTitle.TabStop = false;
            this.toolTipGameSet.SetToolTip(this.picInfoGameSetTitle, "Text that appears at the top of the screen for all games.\r\n(Example: BINGO Madnes" +
        "s)");
            this.picInfoGameSetTitle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblGameSetTitle
            // 
            this.lblGameSetTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGameSetTitle.Location = new System.Drawing.Point(3, 3);
            this.lblGameSetTitle.Name = "lblGameSetTitle";
            this.lblGameSetTitle.Size = new System.Drawing.Size(89, 20);
            this.lblGameSetTitle.TabIndex = 0;
            this.lblGameSetTitle.Text = "Game Set Title:";
            this.lblGameSetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyGameSetTitle
            // 
            this.notifyGameSetTitle.BalloonTipText = "This is the text that appears at the top of the screen for all games./r/n(Example" +
    ": BINGO Madness)";
            this.notifyGameSetTitle.BalloonTipTitle = "Game Set Title";
            this.notifyGameSetTitle.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyGameSetTitle.Icon")));
            this.notifyGameSetTitle.Text = "notifyIcon1";
            this.notifyGameSetTitle.Visible = true;
            // 
            // toolTipGameSet
            // 
            this.toolTipGameSet.IsBalloon = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(3, 3);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(46, 23);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Add";
            this.toolTipGameSet.SetToolTip(this.cmdAdd, "Add a new game");
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(55, 3);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(46, 23);
            this.cmdDelete.TabIndex = 1;
            this.cmdDelete.Text = "Delete";
            this.toolTipGameSet.SetToolTip(this.cmdDelete, "Delete the selected game");
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdMoveUp
            // 
            this.cmdMoveUp.Location = new System.Drawing.Point(3, 32);
            this.cmdMoveUp.Name = "cmdMoveUp";
            this.cmdMoveUp.Size = new System.Drawing.Size(46, 23);
            this.cmdMoveUp.TabIndex = 2;
            this.cmdMoveUp.Text = "Up";
            this.toolTipGameSet.SetToolTip(this.cmdMoveUp, "Move the game up in the list (Earlier)");
            this.cmdMoveUp.UseVisualStyleBackColor = true;
            this.cmdMoveUp.Click += new System.EventHandler(this.cmdMoveUp_Click);
            // 
            // cmdMoveDown
            // 
            this.cmdMoveDown.Location = new System.Drawing.Point(55, 32);
            this.cmdMoveDown.Name = "cmdMoveDown";
            this.cmdMoveDown.Size = new System.Drawing.Size(46, 23);
            this.cmdMoveDown.TabIndex = 3;
            this.cmdMoveDown.Text = "Down";
            this.toolTipGameSet.SetToolTip(this.cmdMoveDown, "Move the game down in the list (Later)");
            this.cmdMoveDown.UseVisualStyleBackColor = true;
            this.cmdMoveDown.Click += new System.EventHandler(this.cmdMoveDown_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(107, 3);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(46, 23);
            this.cmdCopy.TabIndex = 4;
            this.cmdCopy.Text = "Copy";
            this.toolTipGameSet.SetToolTip(this.cmdCopy, "Copy the selected game");
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // picInfoGameTitle
            // 
            this.picInfoGameTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.picInfoGameTitle.Image = ((System.Drawing.Image)(resources.GetObject("picInfoGameTitle.Image")));
            this.picInfoGameTitle.Location = new System.Drawing.Point(387, 3);
            this.picInfoGameTitle.Name = "picInfoGameTitle";
            this.picInfoGameTitle.Size = new System.Drawing.Size(22, 20);
            this.picInfoGameTitle.TabIndex = 1;
            this.picInfoGameTitle.TabStop = false;
            this.toolTipGameSet.SetToolTip(this.picInfoGameTitle, "Text that appears above the sample card\r\n(Example: Four Corners)");
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.cmdOK);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(0, 398);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(624, 44);
            this.panButtons.TabIndex = 1;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(305, 18);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstGames);
            this.splitContainer1.Panel1.Controls.Add(this.panGamesButtons);
            this.splitContainer1.Panel1.Controls.Add(this.lblGames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panCard);
            this.splitContainer1.Panel2.Controls.Add(this.panCardButtons);
            this.splitContainer1.Panel2.Controls.Add(this.panGameTitle);
            this.splitContainer1.Size = new System.Drawing.Size(624, 372);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 2;
            // 
            // lstGames
            // 
            this.lstGames.DisplayMember = "Name";
            this.lstGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(0, 79);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(208, 293);
            this.lstGames.TabIndex = 2;
            this.lstGames.SelectedIndexChanged += new System.EventHandler(this.lstGames_SelectedIndexChanged);
            // 
            // panGamesButtons
            // 
            this.panGamesButtons.Controls.Add(this.cmdCopy);
            this.panGamesButtons.Controls.Add(this.cmdMoveDown);
            this.panGamesButtons.Controls.Add(this.cmdMoveUp);
            this.panGamesButtons.Controls.Add(this.cmdDelete);
            this.panGamesButtons.Controls.Add(this.cmdAdd);
            this.panGamesButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGamesButtons.Location = new System.Drawing.Point(0, 17);
            this.panGamesButtons.Name = "panGamesButtons";
            this.panGamesButtons.Padding = new System.Windows.Forms.Padding(3);
            this.panGamesButtons.Size = new System.Drawing.Size(208, 62);
            this.panGamesButtons.TabIndex = 1;
            // 
            // lblGames
            // 
            this.lblGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGames.Location = new System.Drawing.Point(0, 0);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(208, 17);
            this.lblGames.TabIndex = 0;
            this.lblGames.Text = "Games";
            this.lblGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCard
            // 
            this.panCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCard.Location = new System.Drawing.Point(0, 26);
            this.panCard.Name = "panCard";
            this.panCard.Size = new System.Drawing.Size(412, 292);
            this.panCard.TabIndex = 3;
            // 
            // panCardButtons
            // 
            this.panCardButtons.Controls.Add(this.cmdCancel);
            this.panCardButtons.Controls.Add(this.cmdSave);
            this.panCardButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panCardButtons.Location = new System.Drawing.Point(0, 318);
            this.panCardButtons.Name = "panCardButtons";
            this.panCardButtons.Size = new System.Drawing.Size(412, 54);
            this.panCardButtons.TabIndex = 2;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(206, 16);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(93, 16);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Update";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // panGameTitle
            // 
            this.panGameTitle.Controls.Add(this.txtGameTitle);
            this.panGameTitle.Controls.Add(this.picInfoGameTitle);
            this.panGameTitle.Controls.Add(this.lblGameTitle);
            this.panGameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGameTitle.Location = new System.Drawing.Point(0, 0);
            this.panGameTitle.Name = "panGameTitle";
            this.panGameTitle.Padding = new System.Windows.Forms.Padding(3);
            this.panGameTitle.Size = new System.Drawing.Size(412, 26);
            this.panGameTitle.TabIndex = 1;
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGameTitle.Location = new System.Drawing.Point(92, 3);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(295, 20);
            this.txtGameTitle.TabIndex = 2;
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGameTitle.Location = new System.Drawing.Point(3, 3);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(89, 20);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Game Title:";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmGameEditor
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.panGameSetTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameEditor";
            this.Text = "Game Editor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGameEditor_FormClosing);
            this.Load += new System.EventHandler(this.frmGameEditor_Load);
            this.Resize += new System.EventHandler(this.frmGameEditor_Resize);
            this.panGameSetTitle.ResumeLayout(false);
            this.panGameSetTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoGameSetTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoGameTitle)).EndInit();
            this.panButtons.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panGamesButtons.ResumeLayout(false);
            this.panCardButtons.ResumeLayout(false);
            this.panGameTitle.ResumeLayout(false);
            this.panGameTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGameSetTitle;
        private System.Windows.Forms.TextBox txtGameSetTitle;
        private System.Windows.Forms.PictureBox picInfoGameSetTitle;
        private System.Windows.Forms.Label lblGameSetTitle;
        private System.Windows.Forms.NotifyIcon notifyGameSetTitle;
        private System.Windows.Forms.ToolTip toolTipGameSet;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Panel panGamesButtons;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Button cmdMoveDown;
        private System.Windows.Forms.Button cmdMoveUp;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Panel panGameTitle;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.PictureBox picInfoGameTitle;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Panel panCard;
        private System.Windows.Forms.Panel panCardButtons;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
    }
}