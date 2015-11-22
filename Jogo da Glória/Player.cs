using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Glória
{
    class Player
    {
        internal bool firstTime { get; set; }

        public int ID { get; set; }
        public int currentPos { get; set; }

        public int drinksCounter { get; set; }

        public Player(int playerID, int playerCurrentPos)
        {
            ID = playerID;
            currentPos = playerCurrentPos;
            drinksCounter = 0;
            firstTime = true;
        }
    }
}
