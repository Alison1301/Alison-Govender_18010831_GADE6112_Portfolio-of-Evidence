using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    abstract class Hero:Character
    {
        public Hero(int x,int y,int HP) : base(x, y,TILETYPE.HERO)
        {
            this.Damage = 2;
            
        }

        public override MOVEMENT ReturnMove(MOVEMENT move = MOVEMENT.NO_MOVEMNET)
        {
            int dir = (int) move-1;

            int maxTries = 10;
            int tries = 0;

            if(vision[dir].tileType == TILETYPE.EMPTY)
            {
                return move;
            }

            return MOVEMENT.NO_MOVEMNET;
        }

        public override string ToString()
        {
            return "Player stats: \n" +
                "HP: " + HP + "/" + maxHP + "\n" +
                "Damage: " + Damage + "\n" + 
                "[" + x +" , " + y +" ]";
        }

    }
}
