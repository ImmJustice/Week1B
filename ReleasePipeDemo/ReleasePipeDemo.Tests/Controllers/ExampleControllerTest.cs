using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReleasePipeDemo.Controllers;

namespace ReleasePipeDemo.Tests.Controllers
{
    [TestClass]
    public class ExampleControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ExampleController controller = new ExampleController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        
    }
}
