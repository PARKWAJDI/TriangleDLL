using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleDLL;

namespace TriangleUT
{
    [TestClass]
    public class UnitTestBySide
    {
        [TestMethod]
        public void TestConstructor()
        {
            TriangleBySideDLL atriangle = new TriangleBySideDLL();

            Assert.AreEqual(atriangle.SideA, 0);
            Assert.AreEqual(atriangle.SideB, 0);
            Assert.AreEqual(atriangle.SideC, 0);
        }

        [TestMethod]
        public void TestProperties()
        {
            TriangleBySideDLL atriangle = new TriangleBySideDLL();
            atriangle.SideA = 2;
            atriangle.SideB = 3;
            atriangle.SideC = 4;

            Assert.AreEqual(atriangle.SideA, 2);
            Assert.AreEqual(atriangle.SideB, 3);
            Assert.AreEqual(atriangle.SideC, 4);
        }

        [TestMethod]
        public void TestArea()
        {
            TriangleBySideDLL atriangle = new TriangleBySideDLL();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.Area(), 6);
        }


        [TestMethod]
        public void TestPerimeter()
        {
            TriangleBySideDLL atriangle = new TriangleBySideDLL();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.Perimeter(), 12);
        }


        [TestMethod]
        public void TestAngle()
        {
            TriangleBySideDLL atriangle = new TriangleBySideDLL();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.AngleAB(), 90);
            Assert.AreEqual(atriangle.AngleAC(), 53);
            Assert.AreEqual(atriangle.AngleBC(), 37);

        }

        [TestMethod]
        public void TestHalfPerimeter()
        {
            TriangleBySideDLL atriangle = new TriangleBySideDLL();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.S(), 6);

        }
    }

        [TestClass]
        public class UnitTestByPoint
        {
            [TestMethod]
            public void TestConstructor()
            {
                TriangleByPointDLL atriangle = new TriangleByPointDLL();
                Assert.AreEqual(atriangle.X1, 0);
                Assert.AreEqual(atriangle.Y1, 0);
                Assert.AreEqual(atriangle.X2, 0);
                Assert.AreEqual(atriangle.Y2, 0);
                Assert.AreEqual(atriangle.X3, 0);
                Assert.AreEqual(atriangle.Y3, 0);
            }

            [TestMethod]
            public void TestProperties()
            {
                TriangleByPointDLL atriangle = new TriangleByPointDLL();
                atriangle.X1 = 5;
                atriangle.Y1 = 5;
                atriangle.X2 = 1;
                atriangle.Y2 = 2;
                atriangle.X3 = 1;
                atriangle.Y3 = 5;

                Assert.AreEqual(atriangle.X1, 5);
                Assert.AreEqual(atriangle.Y1, 5);
                Assert.AreEqual(atriangle.X2, 1);
                Assert.AreEqual(atriangle.Y2, 2);
                Assert.AreEqual(atriangle.X3, 1);
                Assert.AreEqual(atriangle.Y3, 5);
             }

            [TestMethod]
            public void TestArea()
            {
                TriangleByPointDLL atriangle = new TriangleByPointDLL();
                atriangle.X1 = 5;
                atriangle.Y1 = 5;
                atriangle.X2 = 1;
                atriangle.Y2 = 2;
                atriangle.X3 = 1;
                atriangle.Y3 = 5;

                Assert.AreEqual(atriangle.Area(), 6);
            }


            [TestMethod]
            public void TestPerimeter()
            {
                TriangleByPointDLL atriangle = new TriangleByPointDLL();
                atriangle.X1 = 5;
                atriangle.Y1 = 5;
                atriangle.X2 = 1;
                atriangle.Y2 = 2;
                atriangle.X3 = 1;
                atriangle.Y3 = 5;

                Assert.AreEqual(atriangle.Perimeter(), 12);
            }


            [TestMethod]
            public void TestAngle()
            {
                TriangleByPointDLL atriangle = new TriangleByPointDLL();
                atriangle.X1 = 5;
                atriangle.Y1 = 5;
                atriangle.X2 = 1;
                atriangle.Y2 = 2;
                atriangle.X3 = 1;
                atriangle.Y3 = 5;

                Assert.AreEqual(atriangle.AngleAB(), 37);
                Assert.AreEqual(atriangle.AngleAC(), 53);
                Assert.AreEqual(atriangle.AngleBC(), 90);

            }

            [TestMethod]
            public void TestHalfPerimeter()
            {
                TriangleByPointDLL atriangle = new TriangleByPointDLL();
                atriangle.X1 = 5;
                atriangle.Y1 = 5;
                atriangle.X2 = 1;
                atriangle.Y2 = 2;
                atriangle.X3 = 1;
                atriangle.Y3 = 5;

            Assert.AreEqual(atriangle.S(), 6);

            }
        }
}
