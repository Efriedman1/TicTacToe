using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardModel
    {
        private char[,] board = new char[3, 3];
        
        public BoardModel()
        {

        }

        public void recordTurn(PlayerModel currentPlayer, int rowID, int colID)
        {
            board[rowID, colID] = currentPlayer.getIcon;
            

        }

        public bool hasPlayerWon(char playerIcon)
        {
            for (int x = 0; x < 3; x++)
            {
                int iconCount = 0;
                int z = 0;
                if (board[x, 0] == playerIcon)
                {
                    z++;
                }

                if (z == 3)
                {
                    return true;
                }
                for (int y = 0; y < 3; y++)
                {
                    if (board[x,y] == playerIcon)
                    {
                        iconCount++;
                    }

                    if(iconCount == 3)
                    {
                        return true;
                    }
                }
            }

            if ((board[0,0] == playerIcon && board[1,1] == playerIcon && board[2,2] == playerIcon) 
                || (board[0, 2] == playerIcon && board[1, 1] == playerIcon && board[2, 0] == playerIcon))
            {
                return true;
            }
            return false;
        }
    }
}
