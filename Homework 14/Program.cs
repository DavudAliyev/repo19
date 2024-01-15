using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO.Pipes;
using System.Xml.Linq;

namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library[] Books = new Library[0];            
            string opt;

            do
            {
                Console.WriteLine("1. Kitab elave et");
                Console.WriteLine("2. Kitab sil");
                Console.WriteLine("3. Butun kitablara bax");
                Console.WriteLine("4. Secilmis kitaba bax");
                Console.WriteLine("5. Ada gore axtaris et");
                Console.WriteLine("0. Cix");

                Console.WriteLine("Emeliyyati secin: ");
                opt=Console.ReadLine();

                switch(opt)
                {
                    case "1":
                        AddBook(ref Books);
                        Console.WriteLine("Kitab elave olundu");
                        break;
                    case "2":
                        for (int i = 0; i<Books.Length; i++)
                        {
                            Console.WriteLine($"{i}-{Books[i]}");
                        }
                       
                        Console.WriteLine("Name: ");
                        string name=Console.ReadLine();

                        RemoveBookByName(ref Books, name);
                      
                        break;
                    case "3":
                        ShowAllBooks(Books); 
                        break;

                    case "4":
                        break;


                }



            }while (opt != "0");
                
                


            
        }
        
        static void AddBook(ref Library[] book)
        {
            Console.WriteLine("Ad: ");
            string name = Console.ReadLine();
            Console.WriteLine("Price: ");
            string priceStr = Console.ReadLine();
            int price = Convert.ToInt32(priceStr);
            Library newbook = new Library(name, price);
        }

        static void RemoveBookByName(ref Library[] arr, string name)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }

            Array.Resize(ref arr, arr.Length-1);
        }

        static void ShowAllBooks(Library[] books)
        {
            for(int i = 0; i < books.Length; i++)
            {
                books[i].ShowInfo();
            }
        }

    
    }
}
