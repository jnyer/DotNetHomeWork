using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入数组长度：");
                int arrayLength = int.Parse(Console.ReadLine());
                string[] stringArray = new string[arrayLength];
                int[] intArray = new int[arrayLength];
                Console.WriteLine("请依次输入数组元素：");
                stringArray = Console.ReadLine().Split(' ');
                for(int i = 0; i < arrayLength; i++)
                {
                    intArray[i] = int.Parse(stringArray[i]);
                }
                MaxMinNumber(intArray,out int maxNumber,out int minNumber);
                Console.WriteLine("最大值为：" + maxNumber);
                Console.WriteLine("最小值为：" + minNumber);
                AvarageSum(intArray,out int sum,out double avarage);
                Console.WriteLine("平均值为：" + avarage);
                Console.WriteLine("和为:" + sum);

            }
            catch (Exception)
            {
                Console.WriteLine("请输入整数！");
            }
            
        }

        static void MaxMinNumber(int[] array,out int maxNumber,out int minNumber)
        {
            maxNumber = array[0];
            minNumber = array[0];
            for (int flag = 1; flag < array.Length; flag++)
            {
                if (array[flag] > maxNumber)
                {
                    maxNumber = array[flag];
                }
                if (array[flag] < minNumber)
                {
                    minNumber = array[flag];
                }
            }
        }
        static void AvarageSum(int[] array,out int sum,out double avarage)
        {
            sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avarage = (double)sum / array.Length;
        }
    }
}

