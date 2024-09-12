using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Program
    {
        static Validator Validate = new Validator();
        
        static void Main(string[] args)
        {
            double radiusDouble = Validate.validateNumber();
            Circle aCircle = new Circle(radiusDouble);
            do
            {                
                
                double aCircleDiameter = aCircle.CalculateDiameter();
                double aCircleCircumference = aCircle.CalculateCircumference();
                double aCircleArea = aCircle.CalculateArea();
                Console.WriteLine($"aCircle diameter = {aCircleDiameter}");
                Console.WriteLine($"aCircle circumference = {aCircleCircumference}");
                Console.WriteLine($"aCircle area = {aCircleArea}");

            } while (Validate.validateYN(aCircle));
            Console.WriteLine($"Goodbye. aCircle's final radius is {aCircle}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
