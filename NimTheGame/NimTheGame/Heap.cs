using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame 
{
    public class Heap
    {
        private int matches = 0;
        private bool[] values = new bool[0];
        /// <summary>
        /// Generates a heap
        /// </summary>
        /// <param name="size">The size of the heap</param>
        /// <param name="matches">The amount of matches in the heap</param>
        public Heap(int size, int matches)
        {
            this.matches = matches;
            values = new bool[size];
            if (matches > size)
            {
                Console.WriteLine("The amount of matches is greater than the size");
            }
            else
            {
                int count = 0;
                for(int i = 0; i < size; i++)
                {
                    if(count < matches) { values[i] = true; count++; }
                    else { values[i] = false; }
                }
            }
        }
        /// <summary>
        /// This method returns the amount of matches in the heap
        /// </summary>
        /// <returns> The amount of booleans in the heap that's true</returns>
        public int getMatches()
        {
            int i = 0;
            for(int x = 0; x < values.Length; x++)
            {
                if(values[x] == true)
                {
                    i++;
                }
            }
            return i;
        }
        /// <summary>
        /// This method takes in an integer, then changes that amount of booleans 
        /// from true to false. Thus taking away the matches
        /// </summary>
        /// <param name="num">The number of matches within the heap</param>
        public void removeMatches(int num)
        {
            int count = 0;
            for (int x = 0; x < values.Length; x++)
            {
                if(count == num) { break; }
                if (values[x] == true)
                {
                    values[x] = false;
                    count++;
                }
            }
        }
        /// <summary>
        /// This method prints the values within a selected heap: True - (1) False - (0)
        /// </summary>
        /// <returns>The string of the heap</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int x = 0; x < values.Length; x++)
            {
                if (values[x] == true)
                {
                    sb.Append("(1)");
                }
                else if(values[x]==false)
                {
                    sb.Append("(0)");
                }
            }
            return sb.ToString();
        }

    }
}
