using System;
namespace GettingIntoCAgain.CodeCademyApplications
{
    public class ArchitectArithmetic
    {
        public static void CallMe()
        {
            Teotihaucan();
        }
        public static void Teotihaucan()
        {
            double rectangleArea = Rectangles(length: 2500.00, width: 1500.00);
            double circleRadius = Circles(4.00);
            double triangleBase = Triangles(bottom: 10.00, height: 9.00);
            double planTotal = rectangleArea + circleRadius + triangleBase;
            Console.WriteLine($"Teotihaucan plan costs: ${Math.Round(planTotal, 2)}");

            static double Rectangles(double length, double width)
            {
                double area = length * width;
                return area * 180;
            }

            static double Circles(double radius)
            {
                double area = Math.PI * Math.Pow(radius, 2);
                return area * 180;
            }

            static double Triangles(double bottom, double height)
            {
                double area = 0.5 * bottom * height;
                return area * 180;
            }

        }
    }
}
