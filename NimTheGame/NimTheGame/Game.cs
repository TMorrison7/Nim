using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    public class Game
    {
        Board board = new Board();
        Player player1;
        Player player2;
        menu m1 = new menu();

        /// <summary>
        /// This method processes the cpu turn by calling the related methods inside of the player class. This method is only called if one of the players is a cpu.
        /// </summary>
        public void cpuTurn()
        {
            int heap = 0;
            int choice = 0;
            bool run = true;
            do
            {
                heap = player2.cpuHeapSelection(board.getHeapSize());

                if(board.getMaxNumber(heap-1) > 0) { run = false; }
            } while (run);

            choice = player2.cpuMatchSelection(board.getMaxNumber(heap-1));

            Console.WriteLine($"{player2.getName()} has removed {choice} matches from heap {heap}");
            board.removeMatchesFrom(heap-1, choice);
        }

        /// <summary>
        /// This method is called at the end of the game so that the player/players can choose to play again if they want or just quit out of the program
        /// </summary>
        public void endMenu()
        {
            string[] options = new string[] { "Play Again" };
            int choice = m1.promptForInt(options, true);
            if (choice == 1)
            {
                board = new Board();
            }
            else if (choice == 0)
            {
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// This method is called by the turn manager whenever it is a human players turn. it then calls a menu that allows for the user to choose 
        /// a heap and a number of matches to pull from the heap
        /// </summary>
        public void playerTurn()
        {

            List<string> optionsA = new List<string>();

            for (int i = 1; i < board.getHeapSize() + 1; i++)
            {
                optionsA.Add($"Heap {i}");
            }

            string[] heapOptions = optionsA.ToArray();
            bool run = true;
            int choiceA = 0;
            do
            {
                choiceA = m1.promptForInt(heapOptions, false);

                if (board.getMaxNumber(choiceA - 1) > 0) { run = false; };
            } while (run);

            string[] optionsB = new string[board.getMaxNumber(choiceA-1)];
            for (int i = 1; i < board.getMaxNumber(choiceA-1) + 1; i++)
            {
                optionsB[i - 1] = $"Take {i} Matches";
            }
            int choiceB = m1.promptForInt(optionsB, false);
            board.removeMatchesFrom(choiceA - 1, choiceB);
        }
        /// <summary>
        /// This method creates the menu to allow the player to select the difficulty of the game
        /// </summary>
        public void printDifficultyMenu()
        {
            string[] difficulties = { "Easy", "Medium", "Hard" };
            int selection = m1.promptForInt(difficulties, false);
            if (selection == 1)
            {
                board.addHeap(3, 3);
                board.addHeap(3, 3);
            }
            else if (selection == 2)
            {
                board.addHeap(7, 7);
                board.addHeap(7, 5);
                board.addHeap(7, 2);
            }
            else if (selection == 3)
            {
                board.addHeap(9, 9);
                board.addHeap(9, 8);
                board.addHeap(9, 3);
                board.addHeap(9, 2);
            }
        }
        /// <summary>
        /// This is the main menu for the game, it allows the player to select the game mode, it allows the player to view the rules and, it allows the player to exit the game
        /// </summary>
        public void mainMenu()
        {
            do
            {
                Console.WriteLine("Welcome to Nim!");
                Console.WriteLine("Please select an option from bellow.");
                string[] options = { "Player vs Player", "Player vs Computer", "Read the Rules" };
                int selection = m1.promptForInt(options, true);
                if (selection == 0)
                {
                    Environment.Exit(0);
                }
                else if (selection == 1)
                {
                    Console.WriteLine("Player 1:");
                    string p1Name = m1.promptForName();
                    if (p1Name == "" || p1Name.Equals(null))
                    {
                        p1Name = "Dave";
                    }
                    player1 = new Player(p1Name, true, true);

                    Console.WriteLine("Player 2:");
                    string p2Name = m1.promptForName();
                    if (p2Name == "" || p2Name.Equals(null))
                    {
                        p2Name = "Hasselhof";
                    }
                    player2 = new Player(p2Name, true, false);

                    printDifficultyMenu();

                    turnManager();
                }
                else if (selection == 2)
                {
                    Console.WriteLine("Player 1:");
                    string p1Name = m1.promptForName();
                    if (p1Name == "" || p1Name.Equals(null))
                    {
                        p1Name = "Dave";
                    }
                    player1 = new Player(p1Name, true, true);

                    player2 = new Player("Hal 9000", false, false);

                    printDifficultyMenu();

                    turnManager();
                }
                else if (selection == 3)
                {
                    Console.WriteLine("Nim Instructions: \n" +
                        "    The game of nim is fairly easy. all you have to do is not take the last match.\n" +
                        "Depending on which difficulty select there will be a number of heaps, each with \n" +
                        "a different number of matches.\n" +
                        "On your turn you will choose a heap and take any number of the available matches.\n" +
                        "You must take at least one match before your turn is over.\n" +
                        "You can only take matches from one heap each turn.\n" +
                        "The game is over when there are no matches left on the board.\n" +
                        "Whoever takes the last match loses the game.");
                }

            }
            while (true);
        }
        /// <summary>
        /// This is the turn manager, it keeps track of which players turn it currently is and calls the appropreate turn methods.
        /// </summary>
        public void turnManager()
        {
            bool win = false;
            do
            {
                if (player1.getIsTurn())
                {
                    Console.WriteLine($"It is {player1.getName()}'s turn...");
                    if (player1.getIsHuman())
                    {
                        Console.WriteLine(board.ToString());
                        playerTurn();
                        player1.setIsTurn(false);
                        player2.setIsTurn(true);
                    }
                    if (board.checkWin())
                    {
                        Console.WriteLine($"{player2.getName()} has won the game!");
                        win = true;
                    }

                }

                else if (player2.getIsTurn())
                {
                    Console.WriteLine($"It is {player2.getName()}'s turn...");
                    if (player2.getIsHuman())
                    {
                        Console.WriteLine(board.ToString());
                        playerTurn();
                        player1.setIsTurn(true);
                        player2.setIsTurn(false);

                    }
                    else if(!player2.getIsHuman())
                    {
                        cpuTurn();
                        player1.setIsTurn(true);
                        player2.setIsTurn(false);
                    }
                    if (board.checkWin())
                    {
                        Console.WriteLine($"{player1.getName()} has won the game!");
                        win = true;
                    }

                }
            } while (!win);
            endMenu();
        }
    }
}
