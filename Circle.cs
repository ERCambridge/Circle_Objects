using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Circle
    {
        private double pi = Math.PI;
        private double radius;

        public Circle(double radiusValue) 
        {
            radius = radiusValue;
        }

        public double CalculateDiameter() 
        {
            return (2 * radius);
        
        }
        public double CalculateCircumference() 
        {
            return (2 * pi) * radius;
        }
        public double CalculateArea()
        {
            return pi * (Math.Pow(radius,2));
        }

        public void Grow()
        {
            radius *= 2;
        }

        public override string ToString()
        {
            return $"Circle radius value: {radius}";
        }
    }
}
