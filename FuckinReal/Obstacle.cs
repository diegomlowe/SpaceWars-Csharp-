using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuckinReal
{
    class Obstacle : Thing
    {
       
        private float incr = 1f;
        private int pair;

        
        public Obstacle(string c, float x, float y, int pair)
        {
            Random rand = new Random();
            
            this.c = c;
            this.x = x;
            this.y = y;
            this.pair = pair;
        }

        public void move()
        {
            if (pair % 2 == 0)
            {
                if (y == 2 || y == 24) incr = -incr;
                y += incr;
            }
            else
            {
                if (x == 3 || x == 78) incr = -incr;
                x += incr;
            }

        }

    }
    

}
