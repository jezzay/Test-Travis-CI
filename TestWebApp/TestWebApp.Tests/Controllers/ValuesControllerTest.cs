using System.Collections.Generic;
using System.Linq;
using TestWebApp.Controllers;
using Xunit;

namespace TestWebApp.Tests.Controllers
{
    public class ValuesControllerTest
    {
        public void Get()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Equal("value1", result.ElementAt(0));
            Assert.Equal("value2", result.ElementAt(1));
        }


        public void GetById()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.Equal("value", result);
        }


        public void Post()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }


        public void Put()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }


        public void Delete()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}