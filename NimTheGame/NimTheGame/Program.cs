using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimTheGame
{
    class Program
    {
        static Game g = new Game();
        static void Main(string[] args)
        {
            run();
        }
        /// <summary>
        /// this method calls the game for it to start
        /// </summary>
        static void run()
        {
            g.mainMenu();
        }
    }
}