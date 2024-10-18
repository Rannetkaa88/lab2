using System;

class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D()
    {
        X = Y = Z = 0;
    }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Point3D(Point3D other)
    {
        X = other.X;
        Y = other.Y;
        Z = other.Z;
    }

    public void ToInteger()
    {
        X = Math.Round(X);
        Y = Math.Round(Y);
        Z = Math.Round(Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

class Sphere : Point3D
{
    public double Radius { get; set; }

    public Sphere() : base()
    {
        Radius = 1;
    }

    public Sphere(double x, double y, double z, double radius) : base(x, y, z)
    {
        Radius = radius;
    }

    public double Volume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }

    public double SurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }

    public override string ToString()
    {
        return $"Center: {base.ToString()}, Radius: {Radius}";
    }
}

class Program
{
    static double GetValidDoubleInput(string prompt)
    {
        double result;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out result))
            {
                return result;
            }
            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Создать и протестировать Point3D");
            Console.WriteLine("2. Создать и протестировать Sphere");
            Console.WriteLine("3. Выйти из программы");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    TestPoint3D();
                    break;
                case "2":
                    TestSphere();
                    break;
                case "3":
                    Console.WriteLine("Программа завершена.");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1, 2 или 3.");
                    break;
            }
        }
    }

    static void TestPoint3D()
    {
        Console.WriteLine("\nСоздание Point3D:");
        double x = GetValidDoubleInput("Введите X: ");
        double y = GetValidDoubleInput("Введите Y: ");
        double z = GetValidDoubleInput("Введите Z: ");

        Point3D p1 = new Point3D(x, y, z);
        Console.WriteLine("p1: " + p1);

        Point3D p2 = new Point3D(p1);
        Console.WriteLine("p2 (копия p1): " + p2);

        p2.ToInteger();
        Console.WriteLine("p2 после приведения к целым числам: " + p2);
    }

    static void TestSphere()
    {
        Console.WriteLine("\nСоздание Sphere:");
        double x = GetValidDoubleInput("Введите X центра: ");
        double y = GetValidDoubleInput("Введите Y центра: ");
        double z = GetValidDoubleInput("Введите Z центра: ");
        double radius = GetValidDoubleInput("Введите радиус: ");

        Sphere s1 = new Sphere(x, y, z, radius);
        Console.WriteLine("s1: " + s1);
        Console.WriteLine("Объем s1: " + s1.Volume());
        Console.WriteLine("Площадь поверхности s1: " + s1.SurfaceArea());
    }
}
