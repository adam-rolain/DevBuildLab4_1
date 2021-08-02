using System;

namespace Lab4_1ClassAndObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Parellelogram p1 = new Parellelogram() { Length = 12.5, Width = 18.7 };
            p1.Print();
            p1.Resize(25, 10);
            p1.Print();
            Console.WriteLine("-----------------------------");

            Parellelogram p2 = new Parellelogram() { Length = 8.4, Width = 30.9 };
            p2.Print();
            p2.Resize(-10, 10);
            Console.WriteLine("-----------------------------");
            p2.Print();
            Console.WriteLine("-----------------------------");

            Book b1 = new Book() { Title = "The Hunger Games", LastName = "Collins", FirstName = "Suzanne", PublisherName = "Scholastic", ID = "9780439023481", CopiesSold = 800000 };
            b1.Print();
            b1.Sell(100000);
            Console.WriteLine("-----------------------------");
            b1.Print();
            Console.WriteLine("-----------------------------");

            Book b2 = new Book() { Title = "The Kite Runner", LastName = "Hosseini", FirstName = "Khaled", PublisherName = "Riverhead Books", ID = "9783869747798", CopiesSold = 39000000 };
            b2.Print();
            b2.Sell(-20000);
            Console.WriteLine("-----------------------------");
            b2.Print();
            Console.WriteLine("-----------------------------");
        }
    }

    class Parellelogram
    {
        public double Length;
        public double Width;

        public void Resize(double newLength, double newWidth)
        {
            if (newLength <= 0 || newWidth <= 0)
            {
                return;
            }

            Length = newLength;
            Width = newWidth;
        }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return (2 * Length) + (2 * Width);
        }

        public void Print()
        {
            Console.WriteLine("Here is information about the Parellelogram:");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
        }
    }

    class Book
    {
        public string Title;
        public string LastName;
        public string FirstName;
        public string ID;
        public string PublisherName;
        public int CopiesSold;

        public void Sell(int booksSold)
        {
            if (booksSold <= 0)
            {
                return;
            }
            CopiesSold += booksSold;
        }

        public void Print()
        {
            Console.WriteLine($"Here is information on {Title}:");
            Console.WriteLine($"Author: {FirstName} {LastName}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Publisher Name: {PublisherName}");
            Console.WriteLine($"Copies Sold: {CopiesSold}");
        }
    }
}
