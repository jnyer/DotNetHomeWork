using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework3._2
{
    interface Shape
    {
        void calculateArea();
        double Area { get; set; }
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Area { get; set; }
        public Rectangle()
        {
            this.length = new RandomNumber().getRandomNum();
            this.width = new RandomNumber().getRandomNum();
        }
        public void calculateArea()
        {
            Area = length * width;
        }
    }
    class Triangle : Shape
    {
        private double baseSide;
        private double height;

        public double Area { get; set; }
        public Triangle()
        {
            this.baseSide = new RandomNumber().getRandomNum();
            this.height = new RandomNumber().getRandomNum();
        }
        public void calculateArea()
        {
            Area = baseSide * height / 2;
        }
    }
    class Square : Shape
    {
        private double side;
        public double Area { get; set; }
        public Square()
        {
            this.side = new RandomNumber().getRandomNum();
        }
        public void calculateArea()
        {
            Area = side * side;
        }
    }
    class Circle : Shape
    {
        private double radium;
        public double Area { get; set; }
        public Circle()
        {
            this.radium = new RandomNumber().getRandomNum();
        }
        public void calculateArea()
        {
            Area = radium * radium * 3;
        }
    }
    class RandomNumber
    {
        public int getRandomNum()
        {
            Random random = new Random();
            Thread.Sleep(1);
            return random.Next(1, 4);
        }
    }
    class ShapeFactory
    {
        public Shape getShape(int shapeType)
        {
            if (shapeType == 1)
            {
                return new Triangle();
            }
            if (shapeType == 2)
            {
                return new Circle();
            }
            else if (shapeType == 3)
            {
                return new Rectangle();
            }
            else if (shapeType == 4)
            {
                return new Square();
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sumArea=0;
            for(int i=1;i<11;i++)
            {
                Shape randomShape = (new ShapeFactory()).getShape((new RandomNumber()).getRandomNum());
                randomShape.calculateArea();
                sumArea += randomShape.Area;
            }
            Console.WriteLine(sumArea);
        }
    }
}
