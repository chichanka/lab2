using System;

class Rectangle
{
    private double sidex;
    private double sidec;

    public Rectangle(double sidex, double sidec)
    {
        this.sidex = sidex;
        this.sidec = sidec;
    }

    public double CalculateArea()
    {
        return sidex * sidec;
    }

    public double CalculatePerimeter()
    {
        return 2 * (sidex + sidec);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть довжину x сторони прямокутника: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину c сторони прямокутника: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        double area = rectangle.Area;
        double perimeter = rectangle.Perimeter;

        Console.WriteLine($"Площа прямокутника: {area}");
        Console.WriteLine($"Периметр прямокутника: {perimeter}");

        Console.ReadLine();
    }
}