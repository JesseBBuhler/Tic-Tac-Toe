using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class Board
    {
        // default board appearance

        /*

        */

        // receive array from 'Driver' with markers in pos 0-8
        
        public static string ShowBoard(string[] boardMarks)
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
    }
}
