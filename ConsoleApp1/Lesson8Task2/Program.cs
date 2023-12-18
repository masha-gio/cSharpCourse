using Lesson8Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.TransportEngine.Start();
        car.Move();

        Plane plane = new Plane();
        plane.TransportEngine.Start();
        plane.Move();
    }
}