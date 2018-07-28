using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference(int[] arr)
        {
            this.elements = arr;
        }

        public void computeDifference()
        {
            int maxNum = 0;
            int minNum = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (i == 0)
                {
                    maxNum = elements[i];
                    minNum = elements[i];
                }

                if (elements[i] < minNum)
                    minNum = elements[i];

                if (elements[i] > maxNum)
                    maxNum = elements[i];
            }

            this.maximumDifference = Math.Abs(maxNum - minNum);
        }
    }

    class Day14
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
