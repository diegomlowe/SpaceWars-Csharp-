using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuckinReal
{
    class Enemy : Thing
    {

         float xincr = 0.5f, yincr = 0.5f;

         public Enemy(string c, float x, float y)
        {
            Random rand = new Random();
            this.c = c;
            this.x=x;
            this.y=y;

        }
        

        public void move()
        {
            Random rand = new Random();

            int randomMove = rand.Next(1, 5);

            if (randomMove == 1 && x != 78) x += xincr;
            if (randomMove == 2 && x != 2) x -= xincr;
            if (randomMove == 3 && y != 2) y -= yincr;
            if (randomMove == 4 && y != 24) y += yincr;

        }


    }
}
