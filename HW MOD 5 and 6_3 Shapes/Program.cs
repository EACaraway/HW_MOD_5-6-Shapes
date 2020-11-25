using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_MOD_5_and_6_3_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Square 1", 5, 5);
            Rectangle rectangle = new Rectangle("Rectangle 1", 20, 100);
            square.DisplayShape();
            rectangle.DisplayShape();
        }
    }

    //Create a class called Shape that cannot be instantiated. 
    //Include some attributes that most shapes have such as height, width, area, etc. 
    //Then create two different Types of shapes that calculate their area correctly. 
    //Use a collection of Shape objects and display their dimensions and area.

    //class called shape that cannot be instantiated

    public abstract class Shape
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area;
        
        public virtual void DisplayShape()
        {
            Area = Height * Width;
            Console.WriteLine($"{Name}: Height = {Height}, Width = {Width}, Area = {Area}");
        }

        //public Shape(string name, double height, double width)  Why can't I do this?
        //{
        //    Name = name;
        //    Height = height;
        //    Width = width;

        //}


    }

    public class Square: Shape
    {
        public override void DisplayShape()
        {   // check that it is a square
            if (Height == Width)
            {
                Area = Height * Width;
                Console.WriteLine($"{Name}: Height = {Height}, Width = {Width}, Area = {Area}");
            }
            else
            {
                throw new ArgumentException("That is not a Square!");
            }
        }
        //constructor to initialize       
        public Square(string name, double height, double width)
        {
            Name = name;
            Height = height;
            Width = width;

        }
    }

    // inherits from shape
    public class Rectangle: Shape 
    {
        //constructor to initialize
        public Rectangle(string name, double height, double width)
        {
            Name = name;
            Height = height;
            Width = width;

        }
    }
}
