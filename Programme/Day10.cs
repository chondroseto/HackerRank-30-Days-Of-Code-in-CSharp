/*Objective
Today, we're working with binary numbers. Check out the Tutorial tab for learning materials and an instructional video!

Task
Given a base- integer, , convert it to binary(base-). Then find and print the base- integer denoting the maximum number of consecutive 's in 's binary representation.

Input Format
A single integer, .

Constraints
1 <= n <= 10^6

Output Format
Print a single base- integer denoting the maximum number of consecutive 's in the binary representation of .*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Day10
    {
        public static void Main()
        {
            int consecutiveOne = 0;
            int temp = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The base 2 value of {0} is {1}.", n, Base10To2(n));

            string base2Num = Base10To2(n);

            foreach (var item in base2Num.ToCharArray())
            {
                if (item == '1')
                    temp++;
                else
                {
                    if (temp > consecutiveOne)
                        consecutiveOne = temp;

                    temp = 0;
                }
            }

            if (temp != 0 && temp > consecutiveOne)
                consecutiveOne = temp;

            Console.WriteLine("The total consecutive 1's in binary {0} are {1}.", base2Num, consecutiveOne);

            Console.ReadLine();
        }

        protected static string Base10To2(int base10Num)
        {
            string base2Num = "";
            int rem = default(int);

            do
            {
                rem = base10Num % 2;
                base10Num = base10Num / 2;

                base2Num = string.Concat(rem.ToString(), base2Num);
            }
            while (base10Num != 0);

            return base2Num;
        }
    }
}
