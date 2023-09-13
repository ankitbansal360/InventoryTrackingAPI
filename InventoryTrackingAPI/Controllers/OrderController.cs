using Inventory.BAL.Services;
using Inventory.EAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Test
namespace InventoryTrackingAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet("GetOrders")]
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
        [HttpGet("GetOrderById")]
        public Order GetOrder(int orderID)
        {
            return _orderService.GetOrder(orderID);
        }

        [HttpPost("AddOrder")]
        public IActionResult AddOrder([FromBody] Order order)
        {
            _orderService.AddOrder(order);
            return Ok("Order created successfully!!");
        }

        [HttpDelete("DeleteOrder")]
        public IActionResult DeleteOrder(int orderID)
        {
            _orderService.DeleteOrder(orderID);
            return Ok("Order deleted successfully!!");
        }

        [HttpPut("UpdateOrder")]
        public IActionResult UpdateOrder([FromBody] Order order)
        {
            _orderService.UpdateOrder(order);
            return Ok("Order updated successfully!!");
        }
    }
}

//POSTMAN tool - API Testing tool


