using LightsOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace LightsOutTest
{
    [TestClass]
    public class GridCreatorTests
    {
        [TestMethod]
        public void CreateGrid_CreatesGrid_GridOfFive()
        {
            GridObject result = new GridObject(5);

            Assert.AreEqual(25, result.Grid.Length);
        }

        [TestMethod]
        public void PopulateGrid_PopulatesGrid_RandomSetup()
        {
            var result = new GridObject(5);
            bool testResult = false;

            result.PopulateGrid();

            foreach (char c in result.Grid)
            {
                if (c == 'x')
                {
                    testResult = true;
                    break;
                }
            }

            Assert.IsTrue(testResult);
        }
    }
}
