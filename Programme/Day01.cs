using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Day01
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int a = Convert.ToInt32(Console.ReadLine());
            // Declare second integer, double, and String variables.
            double b = Convert.ToDouble(Console.ReadLine());
            // Read and save an integer, double, and String to your variables.
            string c = Convert.ToString(Console.ReadLine());
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + a);
            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + b).ToString("F1"));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + c);
        }
    }
}
