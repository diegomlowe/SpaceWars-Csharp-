using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuckinReal
{
    abstract class Thing
    {
        protected string c;
        protected float x, y;
        //private string p;

        public Thing(){}

        public Thing(String  c)
        {
            Random rand = new Random();
            this.c = c;
            x = rand.Next(3, 78);
            y = rand.Next(2, 24);

        }/*
        public Thing(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        */
        public float getX(){return x;}

        public float getY() { return y; }

        public void setX(float x)
        {
            this.x = x;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public void locate()
        {

            Console.SetCursorPosition((int)x, (int)y);
            Console.Write(this.c);

        }


    }
}
