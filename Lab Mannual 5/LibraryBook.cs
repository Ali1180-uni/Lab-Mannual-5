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
    }
}
