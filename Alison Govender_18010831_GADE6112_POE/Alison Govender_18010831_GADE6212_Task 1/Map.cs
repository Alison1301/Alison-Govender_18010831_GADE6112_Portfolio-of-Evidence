using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Map
    {
        Tile[,] map;
        Hero hero;
        Enemy[] enemies;

        int WIDTH;
        int HEIGHT;
        Random random = new Random();

        public Hero Hero
        {
            get { return hero; }
        }


        public Map(int minWidth,int maxWidth,int minHeight,int maxHeight,int numenemies)
        {
            WIDTH = random.Next(minWidth, maxWidth + 1);
            HEIGHT = random.Next(minHeight, maxHeight + 1);

            map = new Tile[WIDTH, HEIGHT];
            enemies = new Enemy[numenemies];

            InitializeMap();
             
            hero = (Hero) Create(TILETYPE.HERO);
            for(int i =0;i < enemies.Length; i++)
            {
                enemies[i]= (Enemy) Create(TILETYPE.ENEMY);
            }

            UpdateVision();
            
        }

       

        private void InitializeMap()
        {
            for(int y = 0; y < HEIGHT; y++)
            {
                for(int x = 0; x < WIDTH; x++)
                {
                    if(x==0 || x == WIDTH - 1|| y == 0 || y == HEIGHT - 1)
                    {
                        map[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        map[x, y] = new EmptyTile(x, y);
                    }
                 
                }
            }
        }
       
        private Tile Create(TILETYPE tileType)
        {
            int x = random.Next(0, WIDTH);
            int y = random.Next(0, HEIGHT);

            while (map[x, y].tileType != TILETYPE.EMPTY)
            {
                x = random.Next(0, WIDTH);
                y = random.Next(0, HEIGHT);
            } 

            if(tileType == TILETYPE.HERO)
            {

                map[x, y] = new Hero(x, y, 10);
                return new Hero(x, y, 10);
                
            }
            else if(tileType == TILETYPE.ENEMY)
            {
                map[x,y]= new Goblim(x, y);
                return new Goblim(x, y);
            }

            return map[x,y];
  
        }

        public void UpdateVision()
        {
            UpdateCharacterVision(hero);

            for(int i = 0; i < enemies.Length; i++)
            {
                UpdateCharacterVision(enemies[i]);
            }

        }

        private void UpdateCharacterVision(Character character)
        {
            Tile tileUp = null;
            Tile tileDown = null;
            Tile tileLeft = null;
            Tile tileRight = null;

            if (character.Y + 1 < HEIGHT)
            {
                tileUp = map[character.X, character.Y + 1];
            }
            if (hero.Y - 1 >= 0)
            {
                tileDown = map[character.X, character.Y - 1];
            }
            if (hero.X < WIDTH)
            {
                tileRight = map[character.X + 1, character.Y];
            }
            if (hero.X - 1 >= 0)
            {
                tileLeft = map[character.X - 1, character.Y];
            }

            hero.SetVision(tileUp, tileDown, tileLeft, tileRight);

            
        }

        public override string ToString()
        {

            string mapString = "";

            for(int y = 0;y < HEIGHT;y++)
            {
                for(int x = 0;x < WIDTH; x++)
                {
                    TILETYPE currentType = map[x, y].TileType;
                    if(currentType == TILETYPE.HERO)
                    {
                        mapString += 'H';
                    }
                    else if(currentType == TILETYPE.ENEMY)
                    {
                        mapString += 'G';
                    }
                    else if(currentType == TILETYPE.EMPTY)
                    {
                        mapString += '.';
                    }
                    else if(currentType == TILETYPE.OBSTACLE)
                    {
                        mapString += 'X';
                    }
                }

                mapString += "/n";
            }
        }

    }
}
