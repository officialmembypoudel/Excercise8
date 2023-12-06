namespace Excercise8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running Program!");

        Point2D point1 = new Point2D(5F, 2F);
        Point2D point2 = new Point2D(7F, 2.5F);

        EuclideanDistance ed = new EuclideanDistance();

        float distance = ed.CalculateDistance(point1, point2);
        Console.WriteLine($"The euclidean distance is: {distance}.");

        Console.ReadKey();
    }
}

