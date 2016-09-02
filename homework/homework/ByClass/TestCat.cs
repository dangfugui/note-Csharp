using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByClass
{
    class TestCat
    {   //私有的    孩子和本   公开
       // private  protected  public    
        public TestCat()
        {
            Console.WriteLine("黑猫--白猫");
            Cat a1 = new Cat("white");
            Cat a2 = new Cat("white");
            Cat a3 = new Cat("black");
            Cat a4 = new Cat("white");
            Console.WriteLine(Cat.black+"--"+Cat.White);
        }
       
    }
    /// <summary>
    ///猫  白猫 黑猫
    /// </summary>
     class Cat
    {
        private static int white;
        //封装
        public static int White
        {
            get { return Cat.white; }
            set { Cat.white = value; }
        }
        public static int black;//不封装
        public string colour;
        static Cat()
        {
            white = 0;
            black = 0;
        }
        public Cat(string colour)
        {
            this.colour = colour;
            if (colour == "white")
            {
                white++;
            }
            else if (colour == "black")
            {
                black++;
            }
        }

    }
}
