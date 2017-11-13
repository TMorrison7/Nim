using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    public class Player
    {
        private bool isHuman;
        private bool isTurn;
        private String name;
        /// <summary>
        /// Adds an instance of a player to the game
        /// </summary>
        /// <param name="name">The name of the player added</param>
        /// <param name="isHuman">A statement based on if the is human(true) or a cpu(false)</param>
        /// <param name="isTurn">A statement based on if it's the player turn</param>

        public Player(String name, bool isHuman, bool isTurn)
        {
            this.name = name;
            this.isHuman = isHuman;
            this.isTurn = isTurn;
        }


        /// <summary>
        /// This method returns the string representing the player's name
        /// </summary>
        /// <returns>Player's Name</returns>

        public String getName()
        {
            return name;
        }


        /// <summary>
        /// This method returns true/false depending on if the player is human(true) or a cpu(false)
        /// </summary>
        /// <returns>True or false</returns>
        public bool getIsHuman()
        {
            return isHuman;
        }


        /// <summary>
        /// This method returns true/false depending on if it's the player's turn.
        /// </summary>
        /// <returns>True or false</returns>
        public bool getIsTurn()
        {
            return isTurn;
        }


        /// <summary>
        /// A method that sets the selected instance of the player's class' variable, "name",
        /// to the string passed through the parameters
        /// </summary>
        /// <param name="name"></param>
        public void setName(String name)
        {
            this.name = name;
        }


        /// <summary>
        /// A method that sets the selected instance of the player's class' variable, "isHuman",
        /// to the boolean passed through the parameters
        /// </summary>
        /// <param name="isHuman"></param>
        public void setIsHuman(bool isHuman)
        {
            this.isHuman = isHuman;
        }
        

        /// <summary>
        /// A method that sets the selected instance of the player's class' variable, "isTurn",
        /// to the boolean passed through the parameters
        /// </summary>
        /// <param name="isTurn"></param>
        public void setIsTurn(bool isTurn)
        {
            this.isTurn = isTurn;
        }
        

        /// <summary>
        /// This method has the maximum number of the Heaps that can be selected
        /// passed through the parameters. The cpu selects a random number between
        /// 1 and the Maximum Number
        /// </summary>
        /// <param name="maxNum"></param>
        /// <returns>The Cpu's Integer Selection</returns>
        public int cpuHeapSelection(int maxNum)
        {
            Random rand = new Random();
            int x = rand.Next(1, maxNum);

            return x;
        }
        

        /// <summary>
        /// This method has the maximum number of the matches that can be selected
        /// passed through the parameters. The cpu selects a random number between 
        /// 1 and the Maximum Number.
        /// </summary>
        /// <param name="maxNum"></param>
        /// <returns>The Cpu's Integer Selection</returns>
        public int cpuMatchSelection(int maxNum)
        {
            Random rand = new Random();
            int x = rand.Next(1, maxNum);

            return x;
        }
        
    }
}
