namespace Matix.Test
{
    using Matrix.BL;
    using Matrix.Types;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void TestMatrixTrace3x3(int numberOfMatrix)
        {
            var arrayList = new List<int[,]>();
            arrayList.Add(new int[3, 3]
            {
                {  9,  25, 13 },
                { 64,  51,  6 },
                { 49, 100,  0 }
            });
            arrayList.Add(new int[3, 3]
            {
                { 96, 100,  0 },
                { 17,   4, 56 },
                { 35,  11,  8 }
            });
            arrayList.Add(new int[3, 3]
            {
                { 27,  43,   7 },
                {  0,  17,  53 },
                {  9, 100, 100 }
            });

            var matrix = new Matrix(arrayList[numberOfMatrix]);

            var resultExpected = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
            var resultActual = matrix.FindMatrixTrace();
            Assert.AreEqual(resultExpected, resultActual);

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void TestGetElementsLikeSnailShell3x3(int numberOfMatrix)
        {
            var arrayList = new List<int[,]>();
            arrayList.Add(new int[3, 3]
            {
                {  9,  25, 13 },
                { 64,  51,  6 },
                { 49, 100,  0 }
            });
            arrayList.Add(new int[3, 3]
            {
                { 96, 100,  0 },
                { 17,   4, 56 },
                { 35,  11,  8 }
            });
            arrayList.Add(new int[3, 3]
            {
                { 27,  43,   7 },
                {  0,  17,  53 },
                {  9, 100, 100 }
            });

            var matrix = new Matrix(arrayList[numberOfMatrix]);
            var resultExpectedArray = new int[9]
            {
                matrix[0,0], matrix[0, 1], matrix[0, 2],
                matrix[1,2], matrix[2, 2], matrix[2, 1],
                matrix[2,0], matrix[1, 0], matrix[1, 1]
            };
            var resultActualArray = matrix.GetElementsLikeSnailShell();

            for (int i = 0; i < resultExpectedArray.Length; i++)
            {
                var resultExpected = resultExpectedArray[i];
                var resultActual = resultActualArray[i];
                Assert.AreEqual(resultExpected, resultActual);
            }
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void TestMatrixTrace2x3(int numberOfMatrix)
        {
            var arrayList = new List<int[,]>();
            arrayList.Add(new int[2, 3]
            {
                {  9,  25, 13 },
                { 64,  51,  6 }
            });
            arrayList.Add(new int[2, 3]
            {
                { 96, 100,  0 },
                { 17,   4, 56 }
            });
            arrayList.Add(new int[2, 3]
            {
                { 27,  43,   7 },
                {  0,  17,  53 }
            });

            var matrix = new Matrix(arrayList[numberOfMatrix]);

            var resultExpected = matrix[0, 0] + matrix[1, 1];
            var resultActual = matrix.FindMatrixTrace();
            Assert.AreEqual(resultExpected, resultActual);

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void TestGetElementsLikeSnailShell2x3(int numberOfMatrix)
        {
            var arrayList = new List<int[,]>();
            arrayList.Add(new int[2, 3]
            {
                {  9,  25, 13 },
                { 64,  51,  6 }
            });
            arrayList.Add(new int[2, 3]
            {
                { 96, 100,  0 },
                { 17,   4, 56 }
            });
            arrayList.Add(new int[2, 3]
            {
                { 27,  43,   7 },
                {  0,  17,  53 }
            });

            var matrix = new Matrix(arrayList[numberOfMatrix]);
            var resultExpectedArray = new int[6]
            {
                matrix[0,0], matrix[0, 1], matrix[0, 2],
                matrix[1,2], matrix[1, 1], matrix[1, 0]
            };
            var resultActualArray = matrix.GetElementsLikeSnailShell();

            for (int i = 0; i < resultExpectedArray.Length; i++)
            {
                var resultExpected = resultExpectedArray[i];
                var resultActual = resultActualArray[i];
                Assert.AreEqual(resultExpected, resultActual);
            }
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void TestMatrixTrace3x2(int numberOfMatrix)
        {
            var arrayList = new List<int[,]>();
            arrayList.Add(new int[3, 2]
            {
                {  9,  25 },
                { 64,  51 },
                { 49, 100 }
            });
            arrayList.Add(new int[3, 2]
            {
                { 96, 100 },
                { 17,   4 },
                { 35,  11 }
            });
            arrayList.Add(new int[3, 2]
            {
                { 27,  43 },
                {  0,  17 },
                {  9, 100 }
            });

            var matrix = new Matrix(arrayList[numberOfMatrix]);

            var resultExpected = matrix[0, 0] + matrix[1, 1];
            var resultActual = matrix.FindMatrixTrace();
            Assert.AreEqual(resultExpected, resultActual);

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void TestGetElementsLikeSnailShell3x2(int numberOfMatrix)
        {
            var arrayList = new List<int[,]>();
            arrayList.Add(new int[3, 2]
            {
                {  9,  25 },
                { 64,  51 },
                { 49, 100 }
            });
            arrayList.Add(new int[3, 2]
            {
                { 96, 100 },
                { 17,   4 },
                { 35,  11 }
            });
            arrayList.Add(new int[3, 2]
            {
                { 27,  43 },
                {  0,  17 },
                {  9, 100 }
            });

            var matrix = new Matrix(arrayList[numberOfMatrix]);
            var resultExpectedArray = new int[6]
            {
                matrix[0,0], matrix[0, 1], matrix[1, 1],
                matrix[2,1], matrix[2, 0], matrix[1, 0]
            };
            var resultActualArray = matrix.GetElementsLikeSnailShell();

            for (int i = 0; i < resultExpectedArray.Length; i++)
            {
                var resultExpected = resultExpectedArray[i];
                var resultActual = resultActualArray[i];
                Assert.AreEqual(resultExpected, resultActual);
            }
        }

        [Test]
        public void TestExeptionAroundSizeMatrixSetValue()
        {
            var matrix = new Matrix(3, 3);
            Assert.Throws<InvalidParameterException>(() =>
            {
                matrix[-1, 1] = 2;
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                matrix[1, -1] = 4;
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                matrix.SetValue(-1, 1, 2);
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                matrix.SetValue(1, -1, 4);
            });
        }

        [Test]
        public void TestExeptionAroundSizeMatrixGetValue()
        {
            var matrix = new Matrix(3, 3);
            Assert.Throws<InvalidParameterException>(() =>
            {
                var testThrow = matrix[-1, 1];
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                var testThrow = matrix[1, -1];
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                var testThrow = matrix.GetValue(-1, 1);
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                var testThrow = matrix.GetValue(1, -1);
            });
        }

        [Test]
        public void TestExeptionInitializeMatrix()
        {

            Assert.Throws<InvalidParameterException>(() =>
            {
                var matrix = new Matrix(0, 0);
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                var matrix = new Matrix(-1, -1);
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                var zeroArray = new int[0, 0];
                var matrix = new Matrix(zeroArray);
            });
            Assert.Throws<InvalidParameterException>(() =>
            {
                var matrix = new Matrix(null);
            });
        }
    }
}