using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework_14
{
    internal class Book : Product
    {
        
        public string Genre;

        public Book(string name, int price) : base(name, price)
        {

        } 




        public Book[] Books = new Book[0];

        public void Add(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
    }
}
