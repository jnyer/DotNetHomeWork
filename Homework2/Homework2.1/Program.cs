using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            while (flag == 1)
            {
                Console.Write("请输入要分解的数：");
                int number = int.Parse(Console.ReadLine());
                Console.Write(number + "=");
                FindFactors(number);
                Console.Write(number);
                Console.WriteLine("\n输入1以继续，输入其他以退出");
                try { 
                    flag = int.Parse(Console.ReadLine());
                } catch (Exception)
                {
                    flag = 0;
                }
            }
        }
        static void FindFactors(int number)
        {
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                while (number % i == 0 && number != 1)
                {
                    Console.Write(i);
                    Console.Write('*');
                    number /= i;
                }
                if (number == 1) break;
            }
        }
    }
}
