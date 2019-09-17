using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class PlayerModel
    {
        private string hiddenName;
        private int hiddenWins;
        private char hiddenIcon;

        public PlayerModel(string name, char icon)
        {
            hiddenName = name;
            hiddenIcon = icon;
            hiddenWins = 0;
        }

        public char getIcon
        {
            get { return hiddenIcon; }
        }

        public string getName
        {
            get { return hiddenName; }
        }

        public int getWins
        {
            get { return hiddenWins; }
        }

        public void won()
        {
            hiddenWins = hiddenWins + 1;
        }
    }
}
