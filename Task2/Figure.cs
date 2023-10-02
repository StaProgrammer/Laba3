class Figure
{
    private Point[] points;

    public Figure(Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("Фігура повинна мати від 3 до 5 точок.");
        }
        this.points = points;
    }

    private double GetSideLength(Point A, Point B)
    {
        double deltaX = B.X - A.X;
        double deltaY = B.Y - A.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % points.Length];
            perimeter += GetSideLength(currentPoint, nextPoint);
        }
        Console.WriteLine($"Периметр фiгури: {perimeter}");
    }
}