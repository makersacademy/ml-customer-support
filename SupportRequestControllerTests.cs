using Microsoft.AspNetCore.Mvc;
using SupportApp.Controllers;
using SupportApp.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using System.Text.Json;

namespace SupportApp.Tests
{
    public class SupportRequestControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult_WithListOfRequests()
        {
            // Arrange
            var controller = new SupportRequestController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var viewData = result?.ViewData; // Access ViewData after casting to ViewResult
            var model = Assert.IsAssignableFrom<List<SupportRequest>>(viewData?.Model);
            Assert.NotNull(model);
        }

        [Fact]
        public void AddRequest_AddsNewRequest_AndRedirectsToIndex()
        {
            // Arrange
            var controller = new SupportRequestController();
            string customerName = "John Doe";
            string description = "Need help with product";

            // Act
            var result = controller.AddRequest(customerName, description);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        [Fact]
        public void AddRequest_AddsNewRequest_AndIncrementsRequestNumber()
        {
            // Arrange
            var controller = new SupportRequestController();
            string customerName = "John Doe";
            string description = "Need help with product";

            // Act
            var viewResult = controller.AddRequest(customerName, description) as ViewResult;
            var request = viewResult?.ViewData.Model as SupportRequest;

            // Assert
            Assert.Equal(request.Id, 1);
        }
        
        [Fact]
        public void ResolveRequest_ResolvesRequest_AndRedirectsToIndex()
        {
            // Arrange
            var controller = new SupportRequestController();
            controller.AddRequest("John Doe", "Need help with product");
            int requestId = 1;

            // Act
            var result = controller.ResolveRequest(requestId) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
            var viewResult = controller.Index() as ViewResult;
            var request = viewResult?.ViewData.Model as List<SupportRequest>;
            Assert.NotNull(request);
            Assert.True(request.First().IsResolved);
        }
    }
}