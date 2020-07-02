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

            float deltaX = point1X - point2X;
            float deltaY = point1Y - point2Y;

            float distance = (float) Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            float angle = (float) Math.Atan2( deltaY, deltaX) * (float) (180 / Math.PI);

            Console.WriteLine("Distance between both points = " + distance);
            Console.WriteLine("and angle is: " + angle);
        }
    }
}
