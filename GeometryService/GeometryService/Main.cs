using GeometryService;
using System;

Main();
static void Main()
{
    Console.Clear();
    Console.WriteLine("Работа с геометрическими фигурами\n" +
                      "Выберите фигуру для вычисления площади:\n" + 
                      "1: Круг\n" + 
                      "2: Треугольник\n\n" +
                      "0: Выход из программы");

    while (true)
    {

        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        switch (consoleKeyInfo.Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                SquareCircle();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                SquareTriangle();
                break;
            case ConsoleKey.D0:
            case ConsoleKey.NumPad0:
                Environment.Exit(0);
                break;
            case ConsoleKey.Enter:
                Main();
                break;
        }
    }
}

static void SquareCircle()
{
    Console.Clear();

    Console.Write("Введите радиус круга: ");
    double r = Convert.ToDouble(Console.ReadLine());

    GeometryLibrary.Circle circle = new GeometryLibrary.Circle(r);

    Console.Clear();
    circle.CalculateSqare();

    Console.WriteLine("\nНажмите Enter для выхода в главное меню");
}

static void SquareTriangle()
{
    Console.Clear();
    Console.WriteLine("Введите 1 сторону треугольника: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите 2 сторону треугольника: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите 3 сторону треугольника: ");
    double c = Convert.ToDouble(Console.ReadLine());

    GeometryLibrary.Triangle triangle = new GeometryLibrary.Triangle(a, b, c);
    Console.Clear();

    Console.WriteLine("Проверить треугольник на то, что он является прямоугольным? (выберите 'Да' - y, 'Нет' - n)");
    
    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
    Console.Clear();

    if (consoleKeyInfo.Key == ConsoleKey.Y)
    {
        triangle.IsRightTriangle();
    }

    triangle.CalculateSqare();

    Console.WriteLine("\nНажмите Enter для выхода в главное меню");
}
