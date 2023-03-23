using ValidParentheses.BL;
using Xunit.Sdk;

namespace ValidParentheses.Test
{
    public class ParenthesesCheckerTest
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("()", true)]
        [InlineData("((()))", true)]
        [InlineData("()()()", true)]
        [InlineData("(()())()", true)]
        [InlineData("()(())((()))(())()", true)]
        [InlineData(")(", false)]
        [InlineData("()()(", false)]
        [InlineData("((())", false)]
        [InlineData("())(()", false)]
        [InlineData(")()", false)]
        [InlineData(")", false)]
        public void ValidParenthesesTest(string input, bool expected)
        {
            //arrange
            IParenthesesChecker checker = new ParenthesesChecker();


            //act
            bool actual = checker.ValidParentheses(input);


            //assert
            Assert.Equal(expected, actual);
        }
    }
}