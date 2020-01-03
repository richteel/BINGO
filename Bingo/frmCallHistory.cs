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
    public partial class frmCallHistory : Form
    {
        private FormWindowState _lastWindowState;
        private List<string> _calledList = new List<string>();

        public List<string> CalledList
        {
            set
            {
                _calledList = value;
                lblCalledNumbers.Text = "";
                string strTemp = "";
                foreach (string s in _calledList)
                {
                    if (strTemp.Length > 0)
                    {
                        strTemp = strTemp + "\r\n";
                    }
                    strTemp = strTemp + s;
                }
                lblCalledNumbers.Text = strTemp;
                lblCalledNumbers.SelectionStart = lblCalledNumbers.Text.Length;
                lblCalledNumbers.SelectionLength = 0;
                lblCalledNumbers.ScrollToCaret();
            }
        }

        public FormWindowState LastWindowState
        {
            get { return _lastWindowState; }
        }

        public frmCallHistory()
        {
            InitializeComponent();
        }

        private void frmCallHistory_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                _lastWindowState = this.WindowState;
        }
    }
}
