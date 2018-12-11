using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuckinReal
{
    class Proyectil : Thing
    {

        //private string c;
        private float incr;

        public Proyectil(string s,float y, float x)
        {
            
            if (s == "a")
            {
                incr = -1;
                this.y = y;
                this.x = x - 1;
                c = "<--";
            }
            if (s == "d")
            {
                incr = 1;
                this.y = y;
                this.x = x + 1;
                c = "-->";
            }

        }

        public void move()
        {
            
            this.x += incr;



        }




    }
}
