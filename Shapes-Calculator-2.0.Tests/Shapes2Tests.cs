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
    }
}
