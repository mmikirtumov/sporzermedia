using Microsoft.AspNetCore.Mvc;
using Moq;
using SportzerMedia.Api.Controllers.Order;
using SportzerMedia.AppLayer.Orders;
using Xunit;

namespace SportzerMedia.Test.Api
{
    public class OrdersControllerTest
    {
        private readonly Mock<IOrdersService> _ordersServiceMock;
        private readonly OrdersController _controller;

        public OrdersControllerTest()
        {
            _ordersServiceMock = new Mock<IOrdersService>();
            _controller = new OrdersController(_ordersServiceMock.Object);
        }

        [Fact]
        public void SaveOrder_OrderIsNull_ReturnBadRequest()
        {
            // Arrange
            _ordersServiceMock.Setup(o => o.SaveOrders(It.IsAny<OrdersBase>())).Verifiable();

            // Act
            var result = _controller.Post(null);
            var badResult = result as BadRequestResult;


            // Assert
            _ordersServiceMock.Verify(v => v.SaveOrders(It.IsAny<OrdersBase>()), Times.Never);
            Assert.NotNull(badResult);
            Assert.Equal(400, badResult.StatusCode);
        }

        [Fact]
        public void SaveOrder_CorrectData_ReturnCorrectData()
        {
            // Arrange
            _ordersServiceMock.Setup(o => o.SaveOrders(It.IsAny<OrdersBase>())).Verifiable();

            // Act
            var result = _controller.Post(new OrdersBase());
            var okResult = result as StatusCodeResult;

            // Assert
            _ordersServiceMock.Verify(v => v.SaveOrders(It.IsAny<OrdersBase>()), Times.Once);
            Assert.NotNull(okResult);
            Assert.Equal(201, okResult.StatusCode);
        }
    }
}
