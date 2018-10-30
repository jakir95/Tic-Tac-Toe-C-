using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Get Player names and explain rules
            Console.WriteLine("Enter Player 1's Name");
            String player1 = Console.ReadLine();
            Console.WriteLine(player1 + ", you will be Noughts (O)\n\n");

            Console.WriteLine("Enter Player 2's Name");
            String player2 = Console.ReadLine();
            Console.WriteLine(player2 + ", you will be Crosses (X)\n\n");

            Console.WriteLine("The rules of the game are simple, on your turn select which position on the grid you will like to place X or O on." +
                "\nFirst person to get a match of 3 wins" +
                "\nLets play!");



            // Start game
            //int result = TicTacToe(Player1: player1, Player2: player2);

            int maxTurns = 9;
            int turns = 0;
            int choice;
            int result =0;
            String symbol;
            String playerName;
            String[] grid = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("\n" + player1 + " is Noughts so s/he will start, press enter to begin");
            Console.ReadKey();

            while (turns < maxTurns)
            {

                //clears Console
                Console.Clear();

                // prints simple grid
                Console.WriteLine(DrawGrid(grid));

                //find out whose turn it is
                if (turns % 2 == 0) { playerName = player1; }
                else { playerName = player2; }

                //get input then check 
                Console.WriteLine("It's " + playerName + "'s turn ");
                Console.WriteLine("Choose your position");
                choice = int.Parse(Console.ReadLine());
                while (choice > 9)
                {
                    Console.WriteLine("Whoops, That position does not exist on the grid, try again");
                    choice = int.Parse(Console.ReadLine());
                }
                int position = choice - 1;

                while (grid[position] == "X" || grid[position] == "O")
                {
                    Console.WriteLine("Whoops, That position has already been taken, try again");
                    choice = int.Parse(Console.ReadLine());
                    position = choice - 1;
                }
                if (turns % 2 == 0)
                {
                    symbol = "O";
                }
                else
                {
                    symbol = "X";
                }

                grid[position] = symbol;

                //clears Console
                Console.Clear();

                // prints simple grid
                Console.WriteLine(DrawGrid(grid));

                if (MatchesCheck(grid))
                {
                    if (turns % 2 == 0) { result = 1; break; }
                    else { result = 2; break; }

                }

                turns = turns + 1;

            }


                if (result == 1) { Console.WriteLine(player1 + " has won \nPress any key to exit game"); }
                else if (result == 2) { Console.WriteLine(player2 + " has won \nPress any key to exit game"); }
                else { Console.WriteLine("It's a draw\nPress any key to exit game"); }
            

            Console.ReadKey();
        }


        public static Boolean MatchesCheck(String[] grid)
        {
            //logic for checking who won
            if (grid[0].Equals(grid[1]) && grid[1].Equals(grid[2]))
            {
                return true;
            }
            else if (grid[3].Equals(grid[4]) && grid[4].Equals(grid[5]))
            {
                return true;
            }
            else if (grid[6].Equals(grid[7]) && grid[7].Equals(grid[8]))
            {
                return true;
            }
            else if (grid[0].Equals(grid[3]) && grid[3].Equals(grid[6]))
            {
                return true;
            }
            else if (grid[1].Equals(grid[4]) && grid[4].Equals(grid[7]))
            {
                return true;
            }
            else if (grid[2].Equals(grid[5]) && grid[5].Equals(grid[8]))
            {
                return true;
            }
            else if (grid[0].Equals(grid[4]) && grid[4].Equals(grid[8]))
            {
                return true;
            }
            else if (grid[2].Equals(grid[4]) && grid[4].Equals(grid[6]))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static  String DrawGrid(String[] grid)
        {
            // prints simple grid
            //Console.WriteLine(grid[0] + grid[1] + grid[2] + "\n" +
            //    grid[3] + grid[4] + grid[5] + "\n" +
            //    grid[6] + grid[7] + grid[8]
            //    );

            String board = "";
            board += "\n\n";
            board += "\t\t\t " + grid[0] + " | " + grid[1] + " | " + grid[2] + "\n";
            board += "\t\t\t-----------\n";
            board += "\t\t\t " + grid[3] + " | " + grid[4] + " | " + grid[5] + "\n";
            board += "\t\t\t-----------\n";
            board += "\t\t\t " + grid[6] + " | " + grid[7] + " | " + grid[8] + "\n";

            return board;



        }
    }
}
