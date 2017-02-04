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
/*
        [TestMethod]
        public void checkRegex()
        {
            Expression expression = new Expression();

            string expectedResult = "Success";
            string expressionString = @"\b(?<FirstNum>\d+)\s*\b(?<Operator>[\+\/\-\+\%])\s*\b(?<SecondNum>\d+)";
            expression.VerifyExpression("5+5");
        }
        */
    }
}
