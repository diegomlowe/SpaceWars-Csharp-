using System;
using System.Collections;
using System.Collections.Generic;


namespace FuckinReal
{
    class Player : Thing
    {
       
        ConsoleKeyInfo tecla;
        //ArrayList<Proyectil> list = new ArrayList();
        private ArrayList list = new ArrayList();

        //ArrayList myAL = new ArrayList();
      
        

        public Player(string c, float x, float y)
        {
            Random rand = new Random();
            this.c = c;
            this.x = x;
            this.y = y;

        }

        public ArrayList getPList()
        {

            return list;
        }

               
       // myList.add(90);
        
        
        public void action()
        {

            tecla = Console.ReadKey(false);

            if ((tecla.Key == ConsoleKey.RightArrow) && x != 77) x+=2;
            if ((tecla.Key == ConsoleKey.LeftArrow) && x != 2) x-=2;
            if ((tecla.Key == ConsoleKey.UpArrow) && y != 2) y--;
            if ((tecla.Key == ConsoleKey.DownArrow) && y != 24) y++;
            if (tecla.KeyChar == 'd')
            {
                Proyectil p = new Proyectil("d", this.y, this.x);
                list.Add(p);
            }
            if (tecla.KeyChar == 'a')
            {
                Proyectil p = new Proyectil("a", this.y, this.x);
                list.Add(p);
            }

            
        }/*

        public void action2()
        {

            tecla = Console.ReadKey(false);

            if ((tecla.Key == ConsoleKey.RightArrow) && x != 77) x += 2;
            if ((tecla.Key == ConsoleKey.LeftArrow) && x != 2) x -= 2;
            if ((tecla.Key == ConsoleKey.UpArrow) && y != 2) y--;
            if ((tecla.Key == ConsoleKey.DownArrow) && y != 24) y++;
            if (tecla.KeyChar == 'd')
            {
                Proyectil p = new Proyectil("d", this.y, this.x);
                list.Add(p);
            }
            if (tecla.KeyChar == 'a')
            {
                Proyectil p = new Proyectil("a", this.y, this.x);
                list.Add(p);
            }
            */

        }



    
}
