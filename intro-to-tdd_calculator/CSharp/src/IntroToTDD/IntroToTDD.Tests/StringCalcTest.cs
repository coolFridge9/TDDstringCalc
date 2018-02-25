using Xunit;

namespace IntroToTDD.Tests
{
    public class StringCalcTest
    {
        //When_input_is_x_output_y(1, "i");
        
        [Theory]
        [InlineData("",0)]
        [InlineData("1",1)]
        [InlineData("1,2",3)]
        [InlineData("4",4)]
        [InlineData("5,7",12)]

        public void When_input_is_numbers_output_sum(string numbers, int sum)
        {
            var romanNumeral= new StringCalc();
            var result = romanNumeral.Add(numbers);
            Assert.Equal(sum, result);
        }
    }
}