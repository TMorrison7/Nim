using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    public class Board
    {

        //We need to document changing this to a List
        private List<Heap> heaps = new List<Heap>();

        /// <summary>
        /// Adds a heap of matches to the board
        /// </summary>
        /// <param name="size">The size of the heap to be added</param>
        /// <param name="numberOfMatches">The amount of matches in the heap</param>
        public void addHeap(int size, int numberOfMatches)
        {
            //creates a new heap using the size and # of matches
            Heap heap = new Heap(size, numberOfMatches);
            //adds it to our list of heaps
            heaps.Add(heap);
        }

        /// <summary>
        /// The constructor for the board, this simply instantiates an empty board ready to be modified by the game
        /// </summary>
        public Board() { heaps.Clear(); }

        /// <summary>
        /// This method checks if there is still a possible move to be made.
        /// Returns false if there are still matches on the board
        /// Returns true if someone has won
        /// </summary>
        /// <returns>True or false depending on if someone has won</returns>
        public bool checkWin()
        {
            bool matchesFound = false;

            //check each heap
            foreach(Heap heap in heaps)
            {
                //check if this heap has any matches
                if(heap.getMatches() > 0)
                {
                    //matchesFound is true if matches are found
                    matchesFound = true;
                }
            }
            
            //if matches are found, return false if no one has won, & vice versa
            return !matchesFound;
        }

        /// <summary>
        /// A method that returns the number of heaps on the board
        /// </summary>
        /// <returns>The number of heaps on the board</returns>
        public int getHeapSize()
        {
            //just gets the count of the Heaps in heaps
            return heaps.Count();
        }

        /// <summary>
        /// A method that takes in an integer that represents the heap selected then returns the max amount of matches a player can take from that particular heap
        /// </summary>
        /// <param name="heapSelection">The heap the max number will be found from</param>
        /// <returns>The amount of matches in the heap a player can take</returns>
        public int getMaxNumber(int heapSelection)
        {
            //just referrs to the Heap classes method to count the matches
            return heaps[heapSelection].getMatches();
        }

        /// <summary>
        /// A method that removes a number of matches from a particular heap. This method takes in two integers, the heap selected and the number of matches to be removed from the heap.
        /// </summary>
        /// <param name="heapSelection">The heap the matches will be removed from</param>
        /// <param name="numToBeRemoved">The amount of matches to be removed from the heap</param>
        public void removeMatchesFrom(int heapSelection, int numToBeRemoved)
        {
            heaps[heapSelection].removeMatches(numToBeRemoved);
        }
        /// <summary>
        /// This method prints out each heap in the board collectively
        /// </summary>
        /// <returns>The Board contain heaps</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Heap heap in heaps)
            {
                sb.Append(heap.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
