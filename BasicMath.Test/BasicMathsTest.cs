using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMath.Test
{
    [TestClass]
    public class BasicMathsTest
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            //Arrange
            BasicMaths bm = new BasicMaths();
            //Art
            double resultat = bm.Add(10, 10);
            //Assert
            Assert.AreEqual(resultat, 20);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            //Arrange
            BasicMaths bm = new BasicMaths();
            //Art
            double resultat = bm.Substract(10, 10);
            //Assert
            Assert.AreEqual(resultat, 0);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            //Arrange
            BasicMaths bm = new BasicMaths();
            //Art
            double resultat = bm.divide(10, 5);
            //Assert
            Assert.AreEqual(resultat, 2);
        }


        [TestMethod]
        public void Test_MultiplyMethod()
        {
            //Arrange
            BasicMaths bm = new BasicMaths();
            //Art
            double resultat = bm.Multiply(10, 5);
            //Assert
            Assert.AreEqual(resultat, 50);
        }
    }
}
