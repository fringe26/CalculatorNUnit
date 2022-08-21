namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

       

        [Test]
        public void Additional_10and20_ShouldReturn30()
        {
            //Arrange
            int a = 10;
            int b = 20;
            int expected = 30;

            //Act
            var calc = new Calculator();
            var result = calc.Additional(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Subtraction_20and10_ShouldReturn10()
        {
            //Arrange
            int a = 20;
            int b = 10;
            int expected = 10;

            //Act
            var calc = new Calculator();
            var result = calc.Subtraction(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Miltiplication_20and10_ShouldReturn200()
        {
            //Arrange
            int a = 20;
            int b = 10;
            int expected = 200;

            //Act
            var calc = new Calculator();
            var result = calc.Miltiplication(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Division_20and10_ShouldReturn2()
        {
            //Arrange
            int a = 20;
            int b = 10;
            int expected = 2;

            //Act
            var calc = new Calculator();
            var result = calc.Division(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Division_20and0_ShouldThrownDivideByZeroException()
        {
            //Arrange
            int a = 20;
            int b = 0;
            

            //Act
            var calc = new Calculator();

            //Assert
            Assert.Throws<DivideByZeroException>(() => calc.Division(a, b));
        }



    }
}