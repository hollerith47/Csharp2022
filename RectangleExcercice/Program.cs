using System;

namespace RectangleExcercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(20.3f,10.2f);
            rectangle1.Perimetre();
            Console.WriteLine($"L'aire du rectangle est {rectangle1.Aire()} cm²");
            rectangle1.CouleurRectangle();

            Console.WriteLine();
            Rectangle rectangle2 = new Rectangle(8f, 4, "blue");
            rectangle2.Perimetre();
            Console.WriteLine($"L'aire du rectangle est {rectangle2.Aire()} cm²");
            rectangle2.CouleurRectangle();

        }
    }
}