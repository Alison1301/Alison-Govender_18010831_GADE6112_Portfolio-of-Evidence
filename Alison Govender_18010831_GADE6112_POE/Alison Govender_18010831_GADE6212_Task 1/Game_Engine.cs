using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Game_Engine
    {
        Map map;

        public Game_Engine()
        {
            map = new Map(6, 12, 6, 12, 10);
        }

        public  bool MovePlayer(Movemet desiredMovement)
        {
            Movement move = map.Hero.ReturnMove(desiredMovement);
            map.Hero.Move(allowedMove);

            if(allowedMove == Movement.NO_MOVEMENT)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void EnemyAttacks()
        {

        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}
