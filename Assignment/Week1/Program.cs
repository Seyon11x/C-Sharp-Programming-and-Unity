using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Dear User");
            Console.WriteLine("This application will calculate the distance between two points and the angle between those points.");

            Console.Write("Enter first X value: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("Enter first X value: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.Write("Enter first X value: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("Enter first X value: ");
            float point2Y = float.Parse(Console.ReadLine());

            float deltaX = point2X >= point1X ? point1X - point2X : point2X - point1X;
            float deltaY = point2Y >= point1Y ? point1Y - point2Y : point2Y - point1Y;

            float distance = (float) Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            float angle = (float) Math.Atan2( deltaY, deltaX) * (float) (180 / Math.PI);

            Console.WriteLine("Distance between both points = " + distance);
            Console.WriteLine("and angle is: " + angle);
        }
    }
}
