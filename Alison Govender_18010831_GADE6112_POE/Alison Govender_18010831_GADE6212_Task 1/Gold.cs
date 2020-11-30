using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Gold:Item
    {
        private int numGold;
        Random Roll = new Random();

        public Gold(int x, int y,TILETYPE tileType) : base(x, y, TILETYPE.GOLD)
        {
            this.x = x;
            this.y = y;
            this.tileType = tileType;
            numGold = Roll.Next(1, 5);
        }
    }
}
