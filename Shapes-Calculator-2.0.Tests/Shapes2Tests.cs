using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Calculator_2._0.Tests
{
    [TestClass]
    public class Shapes2Tests
    {
        [TestMethod]
        public void Rectangle_Area_Correct()
        {
            // arrange
            Rectangle rect = new Rectangle(2, 5);
            float expectedArea = 10;

            // act
            float actualArea = rect.Area();

            // assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Rectangle_Perimeter_Correct()
        {
            // arrange
            Rectangle rect = new Rectangle(2, 5);
            float expectedPerimeter = 14;

            // act
            float actualPerimeter = rect.Perimeter();

            // assert
            Assert.AreEqual(actualPerimeter, expectedPerimeter);
        }

        [TestMethod]
        public void Square_Area_Correct()
        {
            // arrange
            Square square = new Square(4);
            float expectedArea = 16;

            // act
            float actualArea = square.Area();

            // assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Square_Perimeter_Correct()
        {
            // arrange
            Square square = new Square(4);
            float expectedPerimeter = 16;

            // act
            float actualPerimeter = square.Perimeter();

            // assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void Circle_Area_Correct()
        {
            // arrange
            Circle circle = new Circle(4);
            float expectedArea = (float)(Math.PI * 4 * 4);

            // act
            float actualArea = circle.Area();

            // assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001f);
        }

        [TestMethod]
        public void Circle_Perimeter_Correct()
        {
            // arrange
            Circle circle = new Circle(1);
            float expectedPerimeter = (float)(2 * Math.PI * 1);

            // act
            float actualPerimeter = circle.Perimeter();

            // assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001f);
        }

        [TestMethod]
        public void Trapezoid_Area_Correct()
        {
            // arrange
            float base1 = 3;
            float base2 = 5;
            float side1 = 4;
            float side2 = 4;
            float height = 2;
            Trapezoid trapezoid = new Trapezoid(base1, base2, height, side1, side2);
            float expectedArea = (base1 + base2) * height / 2;

            // act
            float actualArea = trapezoid.Area();

            // assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001f);
        }

        [TestMethod]
        public void Trapezoid_Perimeter_Correct()
        {
            // arrange
            float base1 = 3;
            float base2 = 5;
            float side1 = 4;
            float side2 = 4;
            float height = 2;
            Trapezoid trapezoid = new Trapezoid(base1, base2, height, side1, side2);
            float expectedPerimeter = base1 + base2 + side1 + side2;

            // act
            float actualPerimeter = trapezoid.Perimeter();

            // assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001f);
        }
    }
}
