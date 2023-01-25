using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe.");
            string[] boardArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Board board = new Board();
            
            bool gameOver = false;
            string winner = "";
            string turn = "X";
            int turnCounter = 0;



            while(!gameOver)
            {
                int selectedSquare = 0;
                bool invalidInput = true;

                //in place of Board.ShowBoard(boardArray);
                //for (int i = 0; i < boardArray.Length; i++)
                //{
                //  Console.WriteLine(boardArray[i]);
                //}
                Console.WriteLine(board.ShowBoard(boardArray));
                Console.Write("It is " + turn + "'s turn. Input the number of the square you want to claim:");
                
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
                        // making the error message red
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That input was invalid.  Please enter a number from 1 to 9 that has not yet been chosen.");
                        //reset the console color
                        Console.ResetColor();
                    }
 
                }

                boardArray[selectedSquare - 1] = turn;

                if (turn == "X")
                {
                    turn = "O";
                }
                else
                {
                    turn = "X";
                }

                //In place of: winner = Board.CheckWinner(boardArray);
                winner = board.CheckWinner(boardArray);
                if(turnCounter >= 8 || winner != "")
                {
                    gameOver = true;
                }
                turnCounter++;
                Console.Clear();
            }

            //in place of Board.ShowBoard(boardArray);
            //for (int i = 0; i < boardArray.Length; i++)
            //{
            //    Console.WriteLine(boardArray[i]);
            //}
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
