using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StorageTest
    {
        [TestMethod]
        public void TestInstance()
        {
            StackStorage stack = new StackStorage();
            Assert.IsNotNull(stack);
        }

        [TestMethod]
        public void CheckIfAddingToStack()
        {
            StackStorage stack = new StackStorage();

        }
    }
}
