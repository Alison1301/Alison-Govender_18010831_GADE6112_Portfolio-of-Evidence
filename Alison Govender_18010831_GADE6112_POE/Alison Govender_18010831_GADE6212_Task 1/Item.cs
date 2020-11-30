using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Item:Tile
    {
        public Item(int x, int y,TILETYPE tileType) : base(x, y, TILETYPE.EMPTY)
        {

        }

        public abstract ToString()
        {
            return;
        }

        
    }
}
