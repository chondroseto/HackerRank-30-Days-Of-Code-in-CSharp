using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Day02
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());
            double tip = (mealCost * tipPercent) / 100;
            double tax = (mealCost * taxPercent) / 100;
            double totalCost = mealCost + tip + tax;
            Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost));
        }
    }
}
