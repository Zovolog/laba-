using System;

namespace Tasks._2
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point(0, 0, "A");
            Point p2 = new Point(0, 1, "B");
            Point p3 = new Point(1, 1, "C");
            Point p4 = new Point(1, 0, "D");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Figure rectangle = new Figure(p1, p2, p3, p4);
            rectangle.CalculatePerimeter();

            Console.ReadLine();
        }
    }
}