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

            Parellelogram p2 = new Parellelogram() { Length = 8.4, Width = 30.9 };
            p2.Print();
            p2.Resize(-10, 10);
            p2.Print();
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
}
