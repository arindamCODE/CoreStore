using System;
//using CoreStore.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CoreStore.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            // Arrange
            var controller = new HomeController(); 

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void VerifyListProductCount()
        {
            var controller = new HomeController();
            var result = Assert.IsType<ViewResult>(controller.List());
            //var model = Assert.IsType<List<Product>>(result.Model);
            Assert
        }
    }
}
