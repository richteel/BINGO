using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;

namespace Bingo.Help
{
    public partial class frmHelp : Form
    {
        /********* START Disable clicks for adverts *********/
        //http://social.msdn.microsoft.com/Forums/vstudio/en-US/1940f513-8b72-4a29-9a57-85427d8fa88a/how-to-disable-click-sound-in-webbrowser-control?forum=csharpgeneral
        const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        const int SET_FEATURE_ON_THREAD = 0x00000001;
        const int SET_FEATURE_ON_PROCESS = 0x00000002;
        const int SET_FEATURE_IN_REGISTRY = 0x00000004;
        const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;
        const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;
        const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;
        const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;
        const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;

        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        static extern int CoInternetSetFeatureEnabled(
            int FeatureEntry,
            [MarshalAs(UnmanagedType.U4)] int dwFlags,
            bool fEnable);

        static void DisableClickSounds()
        {
            CoInternetSetFeatureEnabled(
                FEATURE_DISABLE_NAVIGATION_SOUNDS,
                SET_FEATURE_ON_PROCESS,
                true);
        }

        /********* END Disable clicks for adverts *********/

        private string helpFolder = "";
        private string helpHome = "index.htm";
        private string helpURI = "";
        private FormWindowState _lastWindowState;

        public FormWindowState LastWindowState
        {
            get { return _lastWindowState; }
        }

        public frmHelp()
        {
            InitializeComponent();

            helpFolder = "Help";
            _lastWindowState = this.WindowState;

            if (!Directory.Exists(helpFolder))
                helpFolder = Path.Combine(Application.ExecutablePath, helpFolder);

            if (!Directory.Exists(helpFolder))
                helpFolder = Path.Combine(Application.StartupPath, helpFolder);

            if (!Directory.Exists(helpFolder))
                helpFolder = "";
            else
            {
                DirectoryInfo di = new DirectoryInfo(helpFolder);
                helpFolder = di.FullName;

                helpHome = Path.Combine(helpFolder, helpHome);
                helpURI = "file://" + helpHome.Replace('\\', '/');
                //helpURI = "http://www.thedance.net/browser/";
            }
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            if (File.Exists(helpHome))
            {
                DisableClickSounds();
                webBrowser1.Navigate(helpURI);
            }
        }

        private void frmHelp_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                _lastWindowState = this.WindowState;
        }


    }
}
