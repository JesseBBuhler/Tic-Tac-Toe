
using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class Support
    {
        /* 

        DEFAULT BOARD APPEARANCE

                 |     |      
              1  |  2  |  3
            _____|_____|_____
                 |     |      
              4  |  5  |  6
            _____|_____|_____
                 |     |      
              7  |  8  |  9
                 |     |     
        */

        // receive array from 'driver' (Driver.cs) with markers in pos 0-8
        public string ShowBoard(string[] boardMarks)
        {
            // initialize the output string of the current board
            string currentBoard = "";

            // clean input array, set blanks to numbers to mark blank board positions
            for (int i = 0; i < boardMarks.Length; i++)
            {
                if (boardMarks[i] == null || boardMarks[i] == "")
                {
                    boardMarks[i] = (i + 1).ToString();
                }
            }

            // 'gameboard' *visual* creation - based on representation above ^^

            // vv String formatting vv //
            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";
            currentBoard += boardMarks[0].PadLeft(3) + "|".PadLeft(3) + boardMarks[1].PadLeft(3) + "|".PadLeft(3) + boardMarks[2].PadLeft(3) + "\n";
            currentBoard += "_____|_____|_____\n";
            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";
            currentBoard += boardMarks[3].PadLeft(3) + "|".PadLeft(3) + boardMarks[4].PadLeft(3) + "|".PadLeft(3) + boardMarks[5].PadLeft(3) + "\n";
            currentBoard += "_____|_____|_____\n";
            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";
            currentBoard += boardMarks[6].PadLeft(3) + "|".PadLeft(3) + boardMarks[7].PadLeft(3) + "|".PadLeft(3) + boardMarks[8].PadLeft(3) + "\n";
            currentBoard += "|".PadLeft(6, ' ') + "|".PadLeft(6, ' ').PadRight(12, ' ') + "\n";
            // ^^ End string formatting ^^ //
            return currentBoard;

        }

        // this function runs each player turn to check if someone has won
        public string CheckWinner(string[] currentBoard)
        {
            // stores either "", "X", or "O"; default to "" because "" = no winner
            string winResult = "";

            // check up/down win
            for(int i = 0; i < 3; i++)
            {
                if (currentBoard[i] == currentBoard[i + 3] && currentBoard[i] == currentBoard[i + 6])
                {
                    // set win result to the character that has been found 3-in-a-row
                    winResult = currentBoard[i];
                }
            }
            
            // check right/left win
            for(int i = 0; i<currentBoard.Length; i += 3)
            {
                if (currentBoard[i] == currentBoard[i + 1] && currentBoard[i] == currentBoard[i + 2])
                {
                    winResult = currentBoard[i];
                }
            }

            // check 2 possible diagonal wins
            if (currentBoard[0] == currentBoard[4] && currentBoard[0] == currentBoard[8])
            {
                winResult = currentBoard[0];

            } else if(currentBoard[2] == currentBoard[4] && currentBoard[2] == currentBoard[6])
            {
                winResult = currentBoard[2];
            }

            // return winner: "X", "O", or "" (none)
            return winResult;
        }
    }
}
