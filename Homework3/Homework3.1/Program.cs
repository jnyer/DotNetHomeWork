using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._1
{
    interface Shape
    {
        void calculateArea();
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;
        private double area;
        public double Area { get { return area; } }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                if (length <= 0) throw new Exception("长度不能小于零");
                if (length <= width) throw new Exception("长不能小于等于宽");
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                if (width <= 0) throw new Exception("宽度不能小于零");
                if (width >= length) throw new Exception("宽不能大于等于长");
            }
        }

        public void calculateArea()
        {
            area = length * width;
        }
    }
    class Square : Shape
    {
        private double side;
        private double area;
        public double Area { get { return area; } }
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                if (side <= 0) throw new Exception("边长不能小于零");
            }
        }
        public void calculateArea()
        {
            area = side * side;
        }
    }
    class Triangle : Shape
    {
        private double baseSide;
        private double height;
        private double area;
        public double Area { get { return area; } }
        public double BaseSide
        {
            get { return baseSide; }
            set
            {
                baseSide = value;
                if (baseSide <= 0) throw new Exception("底不能小于零");
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                if (height <= 0) throw new Exception("高不能小于零");
            }
        }
        public void calculateArea()
        {
            area = baseSide * height / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle r = new Triangle();
            r.BaseSide = 6; r.Height = 5;
            r.calculateArea();
            Console.WriteLine(r.Area);
        }
    }
}


