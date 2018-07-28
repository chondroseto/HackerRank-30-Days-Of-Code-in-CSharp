using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Day16
    {
        public static void Main()
        {
            string S = Console.ReadLine();

            int number = 0;

            try
            {
                number = Convert.ToInt32(S);

                Console.WriteLine("{0}", number);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }

            Console.ReadLine();
        }

    }
}
