using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    public class Heap
    {
        /// <summary>
        /// 
        /// </summary>
        private int matches;
        private bool[] values;
        /// <summary>
        /// Generates a heap
        /// </summary>
        /// <param name="size">The size of the heap</param>
        /// <param name="matches">The amount of matches in the heap</param>
        public Heap(int size, int matches)
        {
            for(int x = 0; x < size; x++)
            {
                values[x] = true;
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
            for (int x = 0; x < num; x++)
            {
                if (values[x] == true)
                {
                    values[x] = false;
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
