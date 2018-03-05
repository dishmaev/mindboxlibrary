using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;

namespace MindboxLibraryTest
{
    /// <summary>
    /// Сводное описание для TriangleTests
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        public TriangleTests()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void RightTriangleSquare()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expected = 6;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actual = Math.Round(triangle.Square());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonRightTriangleSquare()
        {
            double sideA = 4;
            double sideB = 5;
            double sideC = 6;

            try
            {
                Triangle triangle = new Triangle(sideA, sideB, sideC);
                Assert.Fail("Call did not raise any exception, but one was expected.");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(NonRightTriangleException), "Exception raised was not the expected type.");
            }
        }
    }
}
