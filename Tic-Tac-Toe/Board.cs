using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class Board
    {
        // default board appearance

        /*
               |      |    
            0  |  1   |  2
           ____|______|____
               |      |
            3  |  4   |  5
           ____|______|____
               |      |
            6  |   7  |  8
               |      |

            */

        // receive array from 'Driver' with markers in pos 0-8

        public string ShowBoard(string[] boardMarks)
        {
            string currentBoard = "";
            for (int i = 0; i < boardMarks.Length; i++)
            {
                if (boardMarks[i] == null || boardMarks[i] == "")
                {
                    boardMarks[i] = (i + 1).ToString();
                }
            } 
            //The padding is so that the lines align with each other. The appropriate Xs and Os are inserted based on the commented gameboard above

            // vvv Start of gameboard creation vvv //
            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";

            currentBoard += boardMarks[0].PadLeft(3) + "|".PadLeft(3) + boardMarks[1].PadLeft(3) + "|".PadLeft(3) + boardMarks[2].PadLeft(3) + "\n";

            currentBoard += "_____|_____|_____\n";

            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";

            currentBoard += boardMarks[3].PadLeft(3) + "|".PadLeft(3) + boardMarks[4].PadLeft(3) + "|".PadLeft(3) + boardMarks[5].PadLeft(3) + "\n";

            currentBoard += "_____|_____|_____\n";

            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";

            currentBoard += boardMarks[6].PadLeft(3) + "|".PadLeft(3) + boardMarks[7].PadLeft(3) + "|".PadLeft(3) + boardMarks[8].PadLeft(3) + "\n";

            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";
            // ^^^ End of gameboard creation ^^^ //

            //return the gameboard
            return currentBoard;

        }

        public string CheckWinner(string[] currentBoard)
        {
            // stores either "", "x", or "o"

            //default to "" because "" = no winner.
            string winResult = "";
            
            //check for 3 in a row going up/down
            for(int i = 0; i < 3; i++)
            {
                if (currentBoard[i] == currentBoard[i + 3] && currentBoard[i] == currentBoard[i + 6])
                {
                    //Someone has won set the winner
                    winResult = currentBoard[i];
                }
            }
            
            //check across for win
            for(int i = 0; i<currentBoard.Length; i += 3)
            {
                if (currentBoard[i] == currentBoard[i + 1] && currentBoard[i] == currentBoard[i + 2])
                {
                    // win result is the person with 3 in a row
                    winResult = currentBoard[i];
                }
            }

            //check diagonal lines
            if (currentBoard[0] == currentBoard[4] && currentBoard[0] == currentBoard[8])
            {
                winResult = currentBoard[0];

            }else if(currentBoard[2] == currentBoard[4] && currentBoard[2] == currentBoard[6])
            {
                winResult = currentBoard[2];
            }

            // return winner(x,o, or "")
            return winResult;
        }
    }
}
