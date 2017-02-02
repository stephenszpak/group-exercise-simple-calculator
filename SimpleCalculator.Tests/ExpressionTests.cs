using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void MyTestMethod()
        {

        }
    }
}
