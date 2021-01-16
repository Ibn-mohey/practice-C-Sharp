using System;

namespace Mosh_project_1.Intermediate
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int X { get; set; }
        public int y { get; set; }

        public virtual void Draw()
        {

        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");

        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}