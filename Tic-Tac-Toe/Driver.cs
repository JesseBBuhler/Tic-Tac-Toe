using System;

namespace Tic_Tac_Toe
{
    class Driver
    {
        //Names: Brayden Buhler, Nate Conrad, Toa Pita, Isaac Waddell
        //Section: 001 (The best section)
        //Team: 14 (The best team)
        //Project Description: This program simulates a Tic - Tac - Toe game using a Driver and Supporting class.
        static void Main(string[] args)
        {

            //welcome user and create board and array
            Console.WriteLine("Welcome to Tic-Tac-Toe.");
            string[] boardArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Support board = new Support();
            
            // counter and state variables
            bool gameOver = false;
            string winner = "";
            string turn = "X";
            int turnCounter = 0;

            
            //loop while the game is still going
            while(!gameOver)
            {
                int selectedSquare = 0;
                bool invalidInput = true;

                // Set the turn color based on whose turn it is
                if(turn == "X")
                {
                    //set the color to blue
                    Console.ForegroundColor = ConsoleColor.Blue;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                // print the board 
                Console.WriteLine(board.ShowBoard(boardArray));
                Console.Write("It is " + turn + "'s turn. Input the number of the square you want to claim:");
                
                //validate input
                while (invalidInput)
                {
                    string userInput = Console.ReadLine();
                    invalidInput = false;
                    if (!int.TryParse(userInput, out selectedSquare))
                    {
                        invalidInput = true;
                    }
                    else if (selectedSquare > 9 || selectedSquare < 1 || boardArray[selectedSquare - 1] == "X" || boardArray[selectedSquare - 1] == "O")
                    {
                        invalidInput = true;
                    }

                    if (invalidInput)
                    {
                        //Warn the user that they have entered something invalid and reprompt (in red color)
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That input was invalid.  Please enter a number from 1 to 9 that has not yet been chosen.");
                        Console.ResetColor();
                    }
 
                }

                //set spot = to x or o

                boardArray[selectedSquare - 1] = turn;

                //change persons turn
                if (turn == "X")
                {
                    turn = "O";
                }
                else
                {
                    turn = "X";
                }

                //check for a winner
                winner = board.CheckWinner(boardArray);
                if(turnCounter >= 8 || winner != "")
                {
                    gameOver = true;
                }
                turnCounter++;
                Console.Clear();
            }

            // print board and show who won
            Console.WriteLine(board.ShowBoard(boardArray));

            if (winner != "")
            {
                Console.WriteLine(winner + " won the game!!!");
            }
            else
            {
                Console.WriteLine("The game was a tie");
            }
            
        }
    }
}
