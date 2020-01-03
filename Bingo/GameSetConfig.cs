using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bingo
{
    [Serializable]
    public class GameSetConfig : PersistableObject
    {
        public string GameName { get; set; }
        public string GamePattern { get; set; }
    }
}
