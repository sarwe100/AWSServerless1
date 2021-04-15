using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AWSServerless1.Controllers;
using AWSServerless1.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;


namespace XUnitTestProject1
{
    public class ShoppingCartControllerTest
    {
        ShoppingCartController _controller;
        IShoppingCartService _service;

        public ShoppingCartControllerTest()
        {
            _service = new ShoppingCartServiceFake();
            _controller = new ShoppingCartController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

       
    }
}
