using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;

namespace Bingo
{
    public partial class Advert : UserControl
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

        private string advertFolder = "";
        private string[] advertFileNames;
        private string[] advertFileURLs;
        private int advertIdx = 0;

        public int AdvertTime_ms
        {
            get { return timer1.Interval; }
            set { timer1.Interval = value; }
        }

        public Advert(string AdvertFolder)
        {
            InitializeComponent();

            advertFolder = AdvertFolder;

            if (!Directory.Exists(advertFolder))
                advertFolder = Path.Combine(Application.ExecutablePath, AdvertFolder);

            if (!Directory.Exists(advertFolder))
                advertFolder = Path.Combine(Application.StartupPath, AdvertFolder);

            if (!Directory.Exists(advertFolder))
                advertFolder = "";
            else
            {
                DirectoryInfo di = new DirectoryInfo(advertFolder);
                advertFolder = di.FullName;
            }
        }

        private void Advert_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(advertFolder))
            {
                if (Directory.GetFiles(advertFolder, "*.htm").Length > 0)
                {
                    advertFileNames = Directory.GetFiles(advertFolder, "*.htm");
                    advertFileURLs = new string[advertFileNames.Length];

                    for (int i = 0; i < advertFileNames.Length; i++)
                    {
                        advertFileURLs[i] = "file:///" + Path.Combine(advertFolder, advertFileNames[i]).Replace('\\', '/');
                    }

                    DisableClickSounds();
                    ShowAdvert();
                }
            }
        }

        private void ShowAdvert()
        {
            timer1.Enabled = false;

            if (advertIdx > advertFileURLs.Length - 1) { advertIdx = 0; }

            webBrowser1.Navigate(advertFileURLs[advertIdx]);

            advertIdx++;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowAdvert();
        }
    }
}
