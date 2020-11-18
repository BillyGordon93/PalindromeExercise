using System;
using Xunit;
using ExampleForPalindrome;


namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();

            //act
            var actual = test.IsAPalindrome(word);


            //assert
            Assert.Equal(expected, actual);

        }
    }
}
