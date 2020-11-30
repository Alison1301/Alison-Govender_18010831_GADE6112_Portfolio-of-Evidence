using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Mage:Enemy
    {
        public Mage(int x, int y, int Damage, int HP, TILETYPE tileType) : base(x, y,5,5, TILETYPE.ENEMY)
        {
            this.Damage = 5;
            this.maxHP = 5;
        }

        public override MOVEMENT ReturnMove(MOVEMENT move = MOVEMENT.NO_MOVEMNET)
        {
            int dir = random.Next(1, 5);

            int maxTries = 10;
            int tries = 0;

            while (vision[dir - 1].tileType != TILETYPE.EMPTY && tries < maxTries)
            {
                dir = random.Next(1, 5);
                tries++;

                if (tries == maxTries)
                {
                    return MOVEMENT.NO_MOVEMNET;
                }
            }

            return (MOVEMENT)dir;
        }
    }
}
