using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_14
{
    internal class Library:Product
    {
        public Library(string name, int price):base(name,price)
        { 
            Name = name;
            Price= price;
        }


        
        
        public Library[] Books=new Library[0];

        public void Add(Library book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1]=book;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Book name: {Name} - Price:{Price}");
        }
    }
}
