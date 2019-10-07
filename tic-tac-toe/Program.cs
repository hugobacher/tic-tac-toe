using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] mainBoard = { '█', '█', '█', '█', '█', '█', '█', '█', '█' };

            Menu(mainBoard);
        }

        //Main menu
        static void Menu(char[] menuBoard)
        {
            Console.Clear();
            Console.WriteLine("Tic Tac Toe\n");
            Console.WriteLine("To start playing type PLAY\nTo see the tutorial type TUTORIAL");
            string startStatus = "";
            while (startStatus != "play" || startStatus != "tutorial") {
              string start = Console.ReadLine();
              startStatus = start.ToLower();
              if (startStatus == "play")
                  Game(menuBoard);
              else if (startStatus == "tutorial")
                  Tutorial(menuBoard);
            }
        }

        //Runs the game
        static void Game(char[] gameBoard)
        {
            char player = 'X';
            int turn = 0;
            Print(gameBoard);
            Console.WriteLine($"Turn: {turn+1}");
            Console.WriteLine($"It's {player}'s turn\n");
            Console.Write("Place: ");
            int location = int.Parse(Console.ReadLine());
            if (location < 10 && location != gameBoard[location]) {
                gameBoard[location-1] = player;
                Print(gameBoard);
            }
            else if (location > 9)
                Console.WriteLine("You can only choose between 1-9!");
            else
                Console.WriteLine("This place is already taken.");
        }

        //Tutorial
        static void Tutorial(char[] tutorialBoard)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("This is a two player game where you plays X's or O's.");
            Console.WriteLine("This is the game board:\n");
            Console.WriteLine("1 | 2 | 3");
            Console.WriteLine("—————————");
            Console.WriteLine("4 | 5 | 6");
            Console.WriteLine("—————————");
            Console.WriteLine("7 | 8 | 9\n");
            Console.WriteLine("When playing type the number where you want to place your X or O.\n");
            Console.WriteLine("Done reading? Type DONE to get back to the main menu!");
            string done = "";
            while (done != "done") {
              string answer = Console.ReadLine();
              done = answer.ToLower();
              if (done == "done")
                  Menu(tutorialBoard);
            }
        }

        //Prints the gameboard
        static void Print(char[] printBoard)
        {
            //Rensa konsollen
            Console.Clear();
            //Skriver ut brädet
            Console.WriteLine("Tic Tac Toe\n");
            Console.WriteLine($"{printBoard[0]} | {printBoard[1]} | {printBoard[2]}");
            Console.WriteLine("—————————");
            Console.WriteLine($"{printBoard[3]} | {printBoard[4]} | {printBoard[5]}");
            Console.WriteLine("—————————");
            Console.WriteLine($"{printBoard[6]} | {printBoard[7]} | {printBoard[8]}\n");
        }
    }
}
