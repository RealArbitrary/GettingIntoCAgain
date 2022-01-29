using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Make a nice ask-the-user app out of this
namespace GettingIntoCAgain.CodeCademyApplications
{
    public class ArchitectArithmetic
    {
        public static void CallMe()
        {
            Teotihaucan();
            //InterDimensionalSpaceRiftCalculator();
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

        //This is used to test when called, it is suppose to return and write
        //to the console the results of above methods, currently hardcoded values
        static void InterDimensionalSpaceRiftCalculator()
        {
            //Console.WriteLine("Specify Two Values for the Rectangle: ");
            //double rectangle1 = Convert.ToDouble(Console.ReadLine());
            //double rectangle2 = Convert.ToDouble(Console.ReadLine());
            
            //double rectangleArea = Rectangles(2500, 1500);
            //double circleRadius = Circles(4.00);
            //double triangleBase = Triangles(10.00, 9.00);
            //Console.WriteLine(
            //    $"rectangle: {rectangleArea}, " +
            //    $"circle: {circleRadius}, " +
            //    $"triangle: {triangleBase}");
        }
    }
}
