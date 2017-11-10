using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    public class Board
    {
        private Heap[] heaps;

        /// <summary>
        /// Adds a heap of matches to the board
        /// </summary>
        /// <param name="size">The size of the heap to be added</param>
        /// <param name="numberOfMatches">The amount of matches in the heap</param>
        public void addHeap(int size, int numberOfMatches)
        {
            Heap heap = new Heap(size, numberOfMatches);
            //uh heaps[i] = heap;
        }

        public Board()
        {
            //i dont know what to do here
        }

        /// <summary>
        /// This method checks if there is still a possible move to be made.
        /// Returns false if there are still matches on the board
        /// Returns true if someone has won
        /// </summary>
        /// <returns>True or false depending on if someone has won</returns>
        public bool checkWin()
        {
            bool matchesFound = false;

            for (int i = 0; i < heaps.Count(); i++)
            {
                if(heaps.ElementAt(i).getMatches() != 0) { matchesFound = true; }
            }

            //if matches are found, return false if no one has won, & vice versa
            return !matchesFound;
        }

        public int getHeapSize()
        {
            return 0;
        }

        public int getMaxNumber(int heapSelection)
        {
            return 0;
        }

        public void removeMatcher(int heapSelection)
        {

        }
    }
}
