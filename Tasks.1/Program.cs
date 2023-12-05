using System;

namespace Tasks._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть довжину першої сторони прямокутника:");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть довжину другої сторони прямокутника:");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

            Console.ReadLine();
        }
    }
}