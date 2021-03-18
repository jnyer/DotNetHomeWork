using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵行数：");
            int rowNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入矩阵列数：");
            int colNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("请依次输入矩阵元素：");

            int[,] matrix = new int[rowNumber, colNumber];
            for (int i = 0; i < rowNumber; i++)
            {
                string str = Console.ReadLine();//首先输入一字符串，表示二维数组的一行数据
                string[] tmp = str.Split(" ".ToCharArray());//通过Split方法以空格作为分隔符将输入的一行字符串分隔开
                for (int j = 0; j < colNumber; j++)
                {
                    matrix[i, j] = int.Parse(tmp[j]);//将分割后的字符赋给二维数组每个元素
                }
            }

            isToeplitzMatrix(matrix, rowNumber, colNumber, out Boolean flag);
            Console.WriteLine(flag);
        }
        static void isToeplitzMatrix(int[,] matrix, int rowNumber, int colNumber, out Boolean flag)
        {
            for (int row = 1; row < rowNumber; ++row)
            {
                for (int col = 1; col < colNumber; ++col)
                {
                    if (row > 0 && col > 0 && matrix[row, col] != matrix[row - 1, col - 1])
                        flag = false;
                }
            }
            flag = true;
        }

    }
}
