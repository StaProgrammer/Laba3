class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Для обчислення, будь ласка, введiть довжину першої сторони прямокутника:");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Для обчислення, будь ласка, введiть довжину другої сторони прямокутника.:");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine("Периметр прямокутника дорiвнює: " + rectangle.Perimeter);
        Console.WriteLine("Площа прямокутника дорiвнює: " + rectangle.Area);

        Console.ReadKey();
    }
}