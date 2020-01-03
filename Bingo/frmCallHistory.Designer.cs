namespace Bingo
{
    partial class frmCallHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCallHistory));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCalledNumbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Called Numbers";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalledNumbers
            // 
            this.lblCalledNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCalledNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalledNumbers.Location = new System.Drawing.Point(0, 23);
            this.lblCalledNumbers.Multiline = true;
            this.lblCalledNumbers.Name = "lblCalledNumbers";
            this.lblCalledNumbers.ReadOnly = true;
            this.lblCalledNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblCalledNumbers.Size = new System.Drawing.Size(259, 339);
            this.lblCalledNumbers.TabIndex = 1;
            this.lblCalledNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCallHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 362);
            this.Controls.Add(this.lblCalledNumbers);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCallHistory";
            this.Text = "BINGO: Called Numbers";
            this.Resize += new System.EventHandler(this.frmCallHistory_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox lblCalledNumbers;
    }
}