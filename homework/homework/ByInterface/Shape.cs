using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByInterface
{
    abstract class Shape
    {
        public string color="";
        public string GetColor(){
            return color;
        }
        public abstract double GetArea();
    }
    class Circle : Shape
    {
        public double r;
        public Circle(double radius)
        {
            r = radius;
        }
        public override double GetArea()
        {
            return r * r * Math.PI;
        }
    }
    class ShapeTest
    {
        public ShapeTest()
        {
            Shape c = new Circle(10);
            Console.WriteLine(c.GetArea());
        }
    }
}
