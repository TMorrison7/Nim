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
            bool continuePrompting = true;
            int selection;
            int min = 1;

            do
            {
                //display the options
                for (int i = 0; i < options.Count(); i++)
                {
                    Console.WriteLine($"{i+1}) {options[i]}");
                }
                //if there is a quit option it will be option 0 so the user needs to be able to select that
                if (withQuit) { Console.WriteLine("0) Quit"); min = 0; }

                Console.Write("\nSelection: ");

                string userInput = Console.ReadLine();

                //if the user input isn't a number, is higher than the amount of options, or is smaller than the amount of options
                if ((!int.TryParse(userInput, out selection)) || selection > options.Count() || selection < min)
                {
                    //tell them and prompt them again
                    Console.WriteLine("\nPlease enter in a number that is available on the list above\n");
                    continuePrompting = true;
                }
                //if the input is good stop prompting for input
                else { continuePrompting = false; }

            } while (continuePrompting);

            //the userinput has already been parsed into an int in the if statement
            return selection;
        }

        /// <summary>
        /// This function prompts the player for a name and returns it.
        /// If given a empty string or null, will return an empty string
        /// </summary>
        /// <returns>The string(name) the player inputs</returns>
        public string promptForName()
        {
            string name = string.Empty;

            Console.WriteLine("Please enter your name");
            string userInput = Console.ReadLine();

            //if the string isn't null or empty
            if(userInput != null && userInput != string.Empty)
            {
                //the name will change from default to the users input
                name = userInput;
            }

            return name;
        }
    }
}
