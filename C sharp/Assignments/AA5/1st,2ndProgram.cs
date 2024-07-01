using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Books.book();
            Console.ReadLine();

            BookShelf shelf = new BookShelf();
            shelf[0] = new Books("To Kill a Mockingbird", "Haper lee");
            shelf[1] = new Books("The great gatsby", "scott fitzgerald");
            shelf[2] = new Books("Something I never told you", "Shravya Bhinder");
            shelf[3] = new Books("The hobbit", "tolkien");
            shelf[4] = new Books("war abd peace", "leo tostoy");
            shelf.DisplayBooks();

            Box box1 = new Box(5.0, 3.0);
            Box box2 = new Box(2.0, 4.0);

            Box box3 = Box.Add(box1, box2);

            Console.WriteLine("Dimensions of Box 1:");
            box1.Display();
            Console.WriteLine();

            Console.WriteLine("Dimensions of Box 2:");
            box2.Display();
            Console.WriteLine();

            Console.WriteLine("Dimensions of Box 3 (Result of Addition):");
            box3.Display();
            Console.ReadLine();

        }
        class Books
        {
            public static void book()
            {

            }
            public string BookName { get; set; }
            public string AuthorName { get; set; }
            public Books(string bookName, string authorName)
            {
                BookName = bookName;
                AuthorName = authorName;
            }
            public void Display()
            {
                Console.WriteLine($"Book Name: {BookName}");
                Console.WriteLine($"Author: {AuthorName}");
                Console.WriteLine();
                Console.Read();
            }
        }
        class BookShelf
        {
            private Books[] books;
            public BookShelf()
            {
                books = new Books[5];
            }
            public Books this[int index]
            {
                get

                {
                    if (index < 0 || index >= books.Length)
                    {
                        throw new IndexOutOfRangeException($"Index {index} is out of range for BookShelf.");
                    }
                    return books[index];
                }
                set
                {
                    if (index < 0 || index >= books.Length)
                    {
                        throw new IndexOutOfRangeException($"Index {index} is out of range for BookShelf.");
                    }
                    books[index] = value;
                }
            }
            public void DisplayBooks()
            {
                Console.WriteLine("Books on the Bookshelf:");
                Console.WriteLine("-----------------------");
                foreach (var book in books)
                {
                    if (book != null)
                    {
                        book.Display();
                    }
                }
            }
        }

 //-----2nd program--------------------------------
        class Box
        {
            public static void boxs()
            {

            }
            public double Length { get; set; }
            public double Breadth { get; set; }
            public Box(double length, double breadth)
            {
                Length = length;
                Breadth = breadth;
            }
            public static Box Add(Box box1, Box box2)
            {
                double newLength = box1.Length + box2.Length;
                double newBreadth = box1.Breadth + box2.Breadth;
                return new Box(newLength, newBreadth);
            }
            public void Display()
            {
                Console.WriteLine($"Length: {Length}");
                Console.WriteLine($"Breadth: {Breadth}");
                Console.ReadLine();
            }
        }
    }
}
       
       
            


            

               

        

   



        
