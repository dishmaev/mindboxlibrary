using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindboxLibrary
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        private void CheckForRightTriangle()
        {
            bool result = false;
            if (sideA > sideB && sideA > sideC)
            {
                result = (Math.Pow(sideA, 2) == (Math.Pow(sideB, 2) + Math.Pow(sideC, 2)));
            }
            else if (sideB > sideA && sideB > sideC)
            {
                result = (Math.Pow(sideB, 2) == (Math.Pow(sideA, 2) + Math.Pow(sideC, 2)));
            }
            else if (sideC > sideA && sideC > sideB)
            {
                result = (Math.Pow(sideC, 2) == (Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
            }
            if (!result)
            {
                throw new NonRightTriangleException();
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            CheckForRightTriangle();
        }

        public override double Square()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
