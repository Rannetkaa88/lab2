using System;

class Point
{
    // Поля
    private double x;
    private double y;

    // Свойства
    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    // Конструктор
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Метод 1: Вычисление расстояния до начала координат
    public double DistanceToOrigin()
    {
        return Math.Sqrt(x * x + y * y);
    }

    // Метод 2: Унарные операции
    public static Point operator --(Point p)
    {
        p.x--;
        p.y--;
        return p;
    }

    public Point SwapCoordinates()
    {
        double temp = x;
        x = y;
        y = temp;
        return this;
    }

    // Операции приведения типа
    public static implicit operator int(Point p)
    {
        return (int)p.x;
    }

    public static explicit operator double(Point p)
    {
        return p.y;
    }

    // Бинарные операции
    public static Point operator -(Point p, int value)
    {
        p.x -= value;
        return p;
    }

    public static Point operator -(int value, Point p)
    {
        p.y -= value;
        return p;
    }

    public static double operator -(Point p1, Point p2)
    {
        double dx = p1.x - p2.x;
        double dy = p1.y - p2.y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    // Перегрузка метода ToString()
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); // Очищаем консоль перед каждым новым циклом

            Point p1 = InputPoint("Введите координаты первой точки (x y): ");
            Point p2 = InputPoint("Введите координаты второй точки (x y): ");

            Console.WriteLine($"\nТочка 1: {p1}");
            Console.WriteLine($"Точка 2: {p2}");

            Console.WriteLine($"\nРасстояние от точки 1 до начала координат: {p1.DistanceToOrigin()}");

            p1--;
            Console.WriteLine($"Точка 1 после уменьшения координат: {p1}");

            p2.SwapCoordinates();
            Console.WriteLine($"Точка 2 после обмена координат: {p2}");

            int x1AsInt = p1;
            double y2AsDouble = (double)p2;
            Console.WriteLine($"Целая часть x координаты точки 1: {x1AsInt}");
            Console.WriteLine($"Y координата точки 2 как double: {y2AsDouble}");

            p1 = p1 - 5;
            p2 = 3 - p2;
            Console.WriteLine($"Точка 1 после вычитания 5 из x: {p1}");
            Console.WriteLine($"Точка 2 после вычитания 3 из y: {p2}");

            double distance = p1 - p2;
            Console.WriteLine($"Расстояние между точками: {distance}");

            Console.WriteLine("\nНажмите 'q' для выхода или любую другую клавишу для продолжения...");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "q")
            {
                break;
            }
        }
    }

    static Point InputPoint(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string[] input = Console.ReadLine().Split();
            if (input.Length == 2 && double.TryParse(input[0], out double x) && double.TryParse(input[1], out double y))
            {
                return new Point(x, y);
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите два числа, разделенных пробелом.");
        }
    }
}
