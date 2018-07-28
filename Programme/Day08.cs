using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    /// <summary>
    /// Rename the class to Solution when submit to Hacker Rank
    /// </summary>
    class Day08
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string name = string.Empty;
            string number = string.Empty;
            int num = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //Read the input for the Dictionary
            for (int i = 1; i <= num; i++)
            {
                string entry = Convert.ToString(Console.ReadLine());

                string[] values = entry.Split(new[] { " " }, StringSplitOptions.None);

                phoneBook.Add(values[0], values[1]);
            }

            List<string> lstName = new List<string>();
            //Get the input (user name) from the end user
            do
            {
                name = Convert.ToString(Console.ReadLine());

                if (name != null && !string.IsNullOrEmpty(name.Trim()))
                    lstName.Add(name.Trim());

            } while (name != null && !string.IsNullOrEmpty(name.Trim()));

            //Print the phone number of the users 
            foreach (string item in lstName)
            {
                if (phoneBook.TryGetValue(item, out number))
                {
                    Console.WriteLine("{0}={1}", item, number);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
