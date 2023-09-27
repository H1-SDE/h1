using Generalt_programmering;

namespace ProgramUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(-1, 34, -4)]
        public void AddAndMultiplyTest(int c, int a, int b) 
        { 
            // arrange

            // act
            int actual = Program.AddAndMultiply(c, a, b);
            // assert
            Assert.Equal(c + a * b, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, -2)]
        [InlineData(-1, 0)]
        [InlineData(1, 1)]
        [InlineData(-2, -2)]
        [InlineData(-1, -13544)]
        [InlineData(-221, 1)]
        [InlineData(2, -1211)]
        [InlineData(-1323, -2131)]
        public void additionTest(double a, double b)
        {
            // arrange

            // act
            double actual = Program.addition(a, b);
            // assert
            Assert.Equal(a + b, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, -2)]
        [InlineData(-1, 0)]
        [InlineData(1, 1)]
        [InlineData(-2, -2)]
        [InlineData(-1, -13544)]
        [InlineData(-221, 1)]
        [InlineData(2, -1211)]
        [InlineData(-1323, -2131)]
        public void substractionTest(double a, double b)
        {
            // arrange

            // act
            double actual = Program.substraction(a, b);
            // assert
            Assert.Equal(a - b, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, -2)]
        [InlineData(-1, 0)]
        [InlineData(1, 1)]
        [InlineData(-2, -2)]
        [InlineData(-1, -13544)]
        [InlineData(-221, 1)]
        [InlineData(2, -1211)]
        [InlineData(-1323, -2131)]
        public void multiplicationTest(double a, double b)
        {
            // arrange

            // act
            double actual = Program.multiplication(a, b);
            // assert
            Assert.Equal(a * b, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, -2)]
        [InlineData(-1, 0)]
        [InlineData(1, 1)]
        [InlineData(-2, -2)]
        [InlineData(-1, -13544)]
        [InlineData(-221, 1)]
        [InlineData(2, -1211)]
        [InlineData(-1323, -2131)]
        public void divisionTest(double a, double b)
        {
            // arrange

            // act
            double actual = Program.division(a, b);
            // assert
            if ((double)a == 0 | (double)b == 0)
            {
                Assert.Equal(a, actual);
                
            } else
            {
                Assert.Equal(a / b, actual);
            }

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, -2, 0)]
        [InlineData(-1, 0, 1)]
        [InlineData(-1, 1, 2)]
        [InlineData(0, -2, 10)]
        [InlineData(1, 0, 331)]
        [InlineData(0, 1, 2341)]
        public void ModuloOperationsTest(int a, int b, int c)
        {
            // arrange

            // act
            int actual;
            if ((double)a == 0 | (double)b == 0 | (double)c == 0)
            {
                actual = a;
            } else
            {
                actual = Program.ModuloOperations(a, b, c);
            }
            // assert
            if ((double)a == 0 | (double)b == 0 | (double)c == 0)
            {
                Assert.Equal(a, actual);
                
            } else 
            {
                Assert.Equal(a % b % c, actual);
            }
        }

        [Theory]
        [InlineData(1432)]
        [InlineData(0)]
        [InlineData(-1324)]
        [InlineData(-1)]

        public void TheCubeOfTest(double a)
        {
            // arrange

            // act
            double actual = Program.TheCubeOf(a);
            // assert
            Assert.Equal(a * a * a, actual);
        }


    }
}