using DEMO_Practice;

namespace SimpleCalculatorTest
{
    public class StringCalculatorTest
    {
        private StringCalculator calculator = new StringCalculator();


        [Fact]
        public void ShouldReturn0ForEmptyString()
        {
            int sum = calculator.Add("");

            Assert.Equal(0, sum);
        }

        [Fact]
        public void ShouldReturnNumberForSingleNumberString()
        {
            int sum = calculator.Add("5");
            Assert.Equal(5, sum);
        }

        [Fact]
        public void ShouldReturnSumForTwoNumberString()
        {
            int sum = calculator.Add("5,10");
            Assert.Equal(15, sum);
        }
    }
}