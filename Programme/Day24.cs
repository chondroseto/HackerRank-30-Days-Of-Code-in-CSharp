using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Node2
    {
        public int data;
        public Node2 next;
        public Node2(int d)
        {
            data = d;
            next = null;
        }

    }

    class Day24
    {
        public static Node2 removeDuplicates(Node2 head)
        {
            //Write your code here

        }

        public static Node2 insert(Node2 head, int data)
        {
            Node2 p = new Node2(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node2 start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node2 head)
        {
            Node2 start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node2 head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }

    }
}
