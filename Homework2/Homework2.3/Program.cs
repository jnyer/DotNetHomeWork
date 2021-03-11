using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要查找素数的上限：");
            int upNumber = int.Parse(Console.ReadLine());
            FindPrimeNumber(upNumber, out int[] primeNumber);
            for (int i = 1; i < upNumber; i++)
            {
                if (primeNumber[i] != 0)
                {
                    Console.WriteLine(primeNumber[i]);
                }
            }
        }
        static void FindPrimeNumber(int upNumber, out int[] primeNumber)
        {
            primeNumber = new int[upNumber + 1];
            int[] flagArray = new int[upNumber + 1];
            flagArray[2] = 0;
            flagArray[3] = 0;
            int sifter = 2;
            for (int flag = 2; flag <= Math.Sqrt(upNumber); flag++)
            {
                if (flagArray[flag] == 0)
                {
                    for (int i = 2; i <= upNumber / sifter; i++) //将不是素数的数筛出
                    {
                        flagArray[sifter * i] = 1;
                    }
                }
                sifter++;
            }
            for (int i = 2; i < flagArray.Length; i++)
            {
                if (flagArray[i] == 0)
                {
                    primeNumber[i] = i;
                }
            }

        }
    }
}
