using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Day11
    {
        public static void Main()
        {
            int[][] arr = new int[6][];
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                for (int j = arr[i].Length; j < 6; j++)
                {
                    Array.Resize(ref arr[i], j+1);

                    //arr[i].SetValue(0, j);
                }
            }

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine("{0}",maxSum);

            Console.ReadLine();
        }
    }
}
