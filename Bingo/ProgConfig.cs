using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Bingo
{
    [Serializable]
    public class ProgConfig : PersistableObject
    {
        private const string configFilename = "ProgConf.xml";

        public string GameSetName { get; set; }

        public string GamePatterns { get; set; }

        private static string ConfigFileName()
        {
            return Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "ProgConf.xml");
        }

        public static ProgConfig LoadConfig()
        {
            string conffilename = ConfigFileName();

            if (File.Exists(conffilename))
                return PersistableObject.Load<ProgConfig>(conffilename);
            else
                return null;
        }

        public void SaveConfig()
        {
            string conffilename = ConfigFileName();

            this.Save<ProgConfig>(conffilename);
        }
    }
}
