using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Mannual_5
{
    internal class LibraryBook
    {
        private string title;
        private string author;
        private bool isAvaliabe;

        public LibraryBook(string title, string author, bool isAvaliabe)
        {
            this.title = title;
            this.author = author;
            this.isAvaliabe = isAvaliabe;
        }
        public LibraryBook(LibraryBook x1)
        {
            this.title = x1.title;
            this.author = x1.author;
            this.isAvaliabe = x1.isAvaliabe;
        }
        public void BorrowBook(bool avail)
        {
            if (avail == true)
            {
                isAvaliabe = false;
            }
            else
            {
                Console.WriteLine("Book is Not Avaliable");
            }
        }
        public void ReturnBook()
        {
            if (isAvaliabe == false)
            {
                isAvaliabe = true;
            }
        }
        public void Status()
        {
            Console.WriteLine($"The Title of Book is: {title}");
            Console.WriteLine($"The  Auther of Book is: {author}");
            Console.WriteLine($"The Availiability of Book is: {isAvaliabe}");
        }
    }
}
