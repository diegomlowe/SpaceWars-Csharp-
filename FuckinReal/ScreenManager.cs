using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace FuckinReal
{
    class ScreenManager
    {

        public void print(bool killedEmAll)
        {

            //(x,1)
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("_");
            }
            //(x,24)
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 24);
                Console.Write("_");
            }

            //(2, y)
            for (int i = 2; i < 25; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }

            //(79, i)
            for (int i = 2; i < 25; i++)
            {
                if (killedEmAll)
                {
                    if (i == 12 || i == 13)
                    {
                        Console.SetCursorPosition(79, i);
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.SetCursorPosition(79, i);
                        Console.Write("|");
                    }
                }
                else
                {

                    Console.SetCursorPosition(79, i);
                    Console.Write("|");
                }
            }
        }

        public void gameOver()
        {
            
            Console.Clear();

            this.print(false);
            
            Console.SetCursorPosition(35, 13);
            Console.Write("GAME OVER");

            Thread.Sleep(4000);
        }

        public void addThingsToLists(ArrayList oList, int oS, ArrayList eList, int eS, Random rand)
        {
            for (int i = 0; i <oS; i++)
            {

                Obstacle obstacle = new Obstacle("#", rand.Next(10, 78), rand.Next(2, 24), i);
                oList.Add(obstacle);
  
            }

            for(int i=0; i<eS; i++){
                Enemy enemy = new Enemy("[|]", rand.Next(10, 78), rand.Next(2, 24));
                eList.Add(enemy);
            }

        }

        public void locateMoveCheckCollition(Player player, ArrayList oList, ArrayList eList, ref bool fin)
        {
            foreach (Enemy e in eList)
            {

                e.locate();
                //e.move();
                if ((player.getX() == e.getX() || player.getX() + 1 == e.getX() || player.getX() + 2 == e.getX() || player.getX() + 3 == e.getX()) && player.getY() == e.getY()) fin = true;
            }

            foreach (Obstacle obs in oList)
            {

                obs.locate();
                obs.move();
                if ((player.getX() == obs.getX() || player.getX() + 1 == obs.getX() || player.getX() + 2 == obs.getX() || player.getX() + 3 == obs.getX()) && player.getY() == obs.getY()) fin=true;
            }


            if (player.getPList().Count != 0)
            {
                foreach (Proyectil p in player.getPList())
                {
                    bool enemigoEliminado = false;
                    p.locate();
                    p.move();

                    if (p.getX() == 1 || p.getX() == 78)
                    {
                        player.getPList().Remove(p);
                        break;
                    }
                    else
                    {
                        foreach (Enemy e in eList)
                        {
                            if (p.getX() == e.getX() && p.getY() == e.getY())
                            {
                                eList.Remove(e);
                                //player.getPList().Remove(p);
                                enemigoEliminado = true;
                                break;

                            }

                        }
                        if (enemigoEliminado == true)
                        {
                            player.getPList().Remove(p);
                            break;
                        }

                    }

                }
            }
        }

        public void start(Player player, Obstacle obs, Enemy e)
        {
            float x, y;

            this.print(false);
            player.locate();
            /*
            Obstacle obs = new Obstacle("o", 10,10, 1);
            Enemy e = new Enemy("[||]", 20, 20);
            */

            Console.SetCursorPosition(2, 9);
            Console.Write("THIS IS YOU");
            Console.SetCursorPosition(7, 10);
            Console.Write("|");
            Console.SetCursorPosition(7, 11);
            Console.Write("V");

            Thread.Sleep(1000);
            /*
            foreach (Obstacle obstacle in oList)
            {
                if (obstacle.getY() > 4 && obstacle.getX()>10) obs=obstacle;
                break;
            }
            foreach (Enemy enemy in eList)
            {
                if (enemy.getY() > 6 && enemy.getX()>10) e = enemy;
            }*/

            x = obs.getX();
            y = obs.getY();

            Console.SetCursorPosition((int)x-7, (int)y-4);
            Console.Write("THEY TOUCH YOU");
            Console.SetCursorPosition((int)x-7, (int)y-3);
            Console.Write("THEY KILL YOU");
            Console.SetCursorPosition((int)x, (int)y-2);
            Console.Write("|");
            Console.SetCursorPosition((int)x, (int)y - 1);
            Console.Write("V");

            obs.locate();

            Thread.Sleep(1000);

            x = e.getX();
            y = e.getY();

            Console.SetCursorPosition((int)x - 5, (int)y - 3);
            Console.Write("YOU KILL THEM");
            Console.SetCursorPosition((int)x+1, (int)y - 2);
            Console.Write("|");
            Console.SetCursorPosition((int)x+1, (int)y - 1);
            Console.Write("V");

            e.locate();

            Thread.Sleep(1000);

            Console.SetCursorPosition(10, 20);
            
            Console.Write("SHOOT LEFT <-- A | D --> SHOOT RIGHT");
            
            Thread.Sleep(4000);

        }
    }
}
