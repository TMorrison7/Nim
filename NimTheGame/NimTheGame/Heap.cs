﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    public class Heap
    {
        private int matches;
        private bool[] values;

        public Heap(int size, int matches)
        {
            for(int x = 0; x < size; x++)
            {
                values[x] = true;
            }
        }

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

        public override string ToString()
        {
            return "";
        }

    }
}
