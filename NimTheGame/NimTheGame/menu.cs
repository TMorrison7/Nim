using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    public class menu
    {
        /// <summary>
        /// This function takes in an Array of Strings to represents the list of selections in a menu 
        /// with a boolean withQuit if a certain menu requires it to have quit selection within it.
        /// This method prompts the user for an int and then the method returns that particular int.
        /// Loops until given valid input
        /// </summary>
        /// <param name="options">An array of strings that represents the options the user must pick from</param>
        /// <param name="withQuit">If true the user will have the option to exit the menu</param>
        /// <returns>the integer the user entered</returns>
        public int promptForInt(string[] options, bool withQuit)
        {
            bool continuePrompting = false;
            int selection;
            int min = 1;

            do
            {
                for (int i = 0; i < options.Count(); i++)
                {
                    Console.WriteLine($"{i+1}) {options[i]}");
                }
                if (withQuit) { Console.WriteLine("0) Quit"); min = 0; }

                Console.Write("\nSelection: ");

                string userInput = Console.ReadLine();

                if ((!int.TryParse(userInput, out selection)) || selection > options.Count() + 1 || selection < min)
                {
                    Console.WriteLine("\nPlease enter in a number that is available on the list above\n");
                    continuePrompting = true;
                }
                else { continuePrompting = false; }

            } while (continuePrompting);

            return selection;
        }

        /// <summary>
        /// This function prompts the player for a name and returns it.
        /// If given a empty string or null, will return default
        /// </summary>
        /// <returns>The string(name) the player inputs</returns>
        public string promptForName()
        {
            string name = "Default";

            Console.WriteLine("Please enter your name");
            string userInput = Console.ReadLine();

            if(userInput != null && userInput != string.Empty)
            {
                name = userInput;
            }

            return name;
        }
    }
}
