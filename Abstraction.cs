using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    using System;

    public abstract class Shape
    {
        
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double radius;

        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }

    class Abstraction
    {
        static void Main()
        {
           
            Shape circle = new Circle(5);
            Console.WriteLine("Circle Area: " + circle.GetArea());

            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
            Console.ReadLine();
        }
    }

}
