namespace Tasks._2
{
    class Point
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }

        public Point(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public override string ToString() => $"Точка: {Name}({X},{Y})";
    }
}