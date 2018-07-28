using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    //Write MyBook class
    class MyBook : Book
    {
        protected int price;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            base.title = title;
            base.author = author;
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}", base.title, base.author, this.price);
        }

    }

    class Day13
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();

            Console.ReadLine();
        }
    }
}
