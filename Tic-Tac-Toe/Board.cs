using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        // default board appearance

        /*

        */

        // receive array from 'Driver' with markers in pos 0-8
        
        static string ShowBoard(string[] boardMarks)
        {
            string newBoard = "";
            for (int i = 0; i < boardMarks.Length; i++)
            {
                if (boardMarks[i] == null || boardMarks[i] == "")
                {
                    boardMarks[i] = (i + 1).ToString();
                }
            }
        }
    }
}
