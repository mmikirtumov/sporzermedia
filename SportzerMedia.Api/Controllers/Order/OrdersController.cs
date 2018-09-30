using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportzerMedia.AppLayer.Orders;

namespace SportzerMedia.Api.Controllers.Order
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]OrdersBase orders)
        {
            if (orders == null)
                return BadRequest();

            _ordersService.SaveOrders(orders);

            return new StatusCodeResult(201);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ordersService.GetOrders());
        }
    }
}
