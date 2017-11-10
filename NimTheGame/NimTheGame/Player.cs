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

        public Player(String name, bool isHuman, bool isTurn)
        {
            this.name = name;
            this.isHuman = isHuman;
            this.isTurn = isTurn;
        }
        public String getName()
        {
            return name;
        }
        public bool getIsHuman()
        {
            return isHuman;
        }
        public bool getIsTurn()
        {
            return isTurn;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setIsHuman(bool isHuman)
        {
            this.isHuman = isHuman;
        }
        public void setIsTurn(bool isTurn)
        {
            this.isTurn = isTurn;
        }
        public int cpuHeapSelection(int maxNum)
        {
            return 0;
        }
        public int cpuMatchSelection(int maxNum)
        {
            return 0;
        }
    }
}
