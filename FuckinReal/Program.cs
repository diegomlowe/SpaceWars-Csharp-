using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace FuckinReal
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            
            ScreenManager sm = new ScreenManager();

            Player player = new Player("<||>", 5,12);
            ArrayList oList = new ArrayList();
            ArrayList eList = new ArrayList();

            for (int i = 0; i < 5; i++)
            {

                sm.addThingsToLists(oList, (i + 1) * 3, eList, (i + 1) * 2, rand);

                if (i == 0)
                {
                    player.locate();
                    oList[0] = new Obstacle("#", 25, 12, 3);
                    eList[0] = new Enemy("[|]", 50, 12);

                    sm.start(player, (Obstacle)oList[0], (Enemy)eList[0]);

                }
                else
                {
              player.setX(1);
                    player.setY(12);
                }


                bool fin = false;
                bool killedEmAll = false;
                bool exit = false;
            
                while (fin == false)
                {

                    Console.Clear();

                    sm.print(killedEmAll);
                
                    player.locate();

                    sm.locateMoveCheckCollition(player, oList, eList, ref fin);
                
                    if (Console.KeyAvailable) player.action();

                    if (eList.Count == 0) killedEmAll = true;

                    if (killedEmAll && player.getX() == 77 && player.getY() == 12)
                    {
                        exit = true;
                        fin = true;
                    }
                
                    Thread.Sleep(40);

                }

                if (!exit)
                {
                    sm.gameOver();
                    break;
                }
               




            }

            


           
            
           
	    }
        
    }

}






