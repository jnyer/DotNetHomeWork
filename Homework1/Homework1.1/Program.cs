using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数字：");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入一个运算符：");
            char c = char.Parse(Console.ReadLine());
            double sum = 0;
            switch (c)
            {
                case '+': sum = a + b; break;
                case '-': sum = a - b; break;
                case '*': sum = a * b; break;
                case '/':
                    if (b == 0) break;
                    else sum = a / b; break;
            }
            if (b == 0 && c == '/') { Console.WriteLine("结果错误"); }
            else { Console.WriteLine("运算结果为：" + sum); }
        }
    }
}
    

