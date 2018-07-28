using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    /// <summary>
    /// Rename the class name to Solution
    /// </summary>
    class Day06
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string s = Convert.ToString(Console.ReadLine());
                string even = string.Empty;
                string odd = string.Empty;

                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        even = string.Concat(even, s[j]);
                    }
                    else
                    {
                        odd = string.Concat(odd, s[j]);
                    }
                }

                Console.WriteLine("{0} {1}", even, odd);
            }
        }
    }
}
