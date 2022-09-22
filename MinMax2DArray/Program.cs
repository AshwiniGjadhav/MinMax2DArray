using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]
            {
                { 3,5,6,1},
                { 6,7,8,2},
                { 7,8,9,6},
            };
            int max = arr[0, 0];
            int min = arr[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }

                }
                Console.WriteLine($"max in row is {max}");
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        Console.WriteLine($"\nMin in array is {min}");
                    }

                }

            }
        }
    }
}
