using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bingo
{
    public class BingoGame
    {
        private int _order = 0;
        private string _name = "";
        private bool _played = false;
        private bool[,] _card = new bool[5,5];

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool[,] Card
        {
            get { return _card; }
            set { _card = value; }
        }

        public int Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public bool Played
        {
            get { return _played; }
            set { _played = value; }
        }

        public bool FromString(string value)
        {
            string[] vals = value.Split('\t');

            if (vals.Length != 4) { return false; }

            _order = int.Parse(vals[0]);
            _name = vals[1];
            _played = bool.Parse(vals[2]);

            string[] squares = vals[3].Split('|');
            if (squares.Length != 25) { return false; }

            int x = 0;
            int y = 0;

            for (int i = 0; i < 25; i++)
            {
                if (x > 4)
                {
                    x = 0;
                    y++;
                }
                _card[x, y] = bool.Parse(squares[i]);
                x++;
            }

            return true;
        }

        public override string ToString()
        {
            string retVal = _order.ToString() + "\t" + _name + "\t" + _played.ToString() + "\t";

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x != 0 || y != 0)
                        retVal = retVal + "|";

                    retVal = retVal + _card[x, y].ToString();
                }
            }

            return retVal;
        }
    }
}
