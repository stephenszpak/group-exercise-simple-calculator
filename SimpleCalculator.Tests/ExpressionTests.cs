using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        //sanity check test
        [TestMethod]
        public void CanCreateAnInstance()
        {
            Expression expression = new Expression();
            Assert.IsNotNull(expression);
        }

        [TestMethod]

        public void CanCheckInput()
        {
            Expression testExpression = new Expression();
            string testPattern = @"^\b(?<FirstNum>\d+)\s*\b(?<Operator>[\+\/\-\*\%])\s*\b(?<SecondNum>\d+)";
            Regex Regex = new Regex(testPattern);

            string test1 = "1+1";
            string test2 = "2 + 2";


            Assert.IsTrue(Regex.IsMatch(test1));
            Assert.IsTrue(Regex.IsMatch(test2));
        }
    }
}
