using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindboxLibrary
{
    public class NonRightTriangleException : Exception
    {
        public NonRightTriangleException()
            : base("Right Triangle is required.")
        {
        }
    }
}
