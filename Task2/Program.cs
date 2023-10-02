using System.Drawing;

class Program
{
    static void Main()
    {
        Point[] points = new Point[]
        {
            new Point(0, 0, "A"),
            new Point(0, 4, "B"),
            new Point(3, 0, "C"),
            new Point(0, 0, "D"),
        };

        try
        {
            Figure figure = new Figure(points);
            Console.WriteLine($"Назва багатокутника: {points[0].Name}");
            figure.CalculatePerimeter();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}