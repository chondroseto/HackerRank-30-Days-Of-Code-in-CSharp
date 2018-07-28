using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Day18
    {
        Queue<char> q;
        Stack<char> s;

        public Day18()
        {
            q = new Queue<char>();
            s = new Stack<char>();
        }


        /// <summary>
        /// Add element in Stack
        /// </summary>
        /// <param name="c"></param>
        void pushCharacter(char c)
        {
            s.Push(c);
        }

        /// <summary>
        /// Remove element from stack
        /// </summary>
        /// <returns></returns>
        char popCharacter()
        {
            return s.Pop();
        }

        /// <summary>
        /// Add element in queue
        /// </summary>
        /// <param name="c"></param>
        void enqueueCharacter(char c)
        {
            q.Enqueue(c);
        }

        /// <summary>
        /// Remove element from queue
        /// </summary>
        /// <returns></returns>
        char dequeueCharacter()
        {
            return q.Dequeue();
        }

        static void Main(String[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Day18 obj = new Day18();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }

            Console.ReadLine();
        }
    }
}
