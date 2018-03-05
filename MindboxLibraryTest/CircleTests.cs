using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;

namespace MindboxLibraryTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleSquare()
        {
            double radius = 10;
            double expected = 314;

            Circle circle = new Circle(radius);
            double actual = Math.Round(circle.Square());
            

            Assert.AreEqual(expected, actual);
        }
    }
}
