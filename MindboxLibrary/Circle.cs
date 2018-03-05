using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindboxLibrary
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
