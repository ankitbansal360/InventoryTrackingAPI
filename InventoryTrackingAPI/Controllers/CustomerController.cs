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
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet("GetAllCustomers")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }
        [HttpGet("GetCustomerById")]
        public Customer GetCustomerById(int customerId)
        {
            return _customerService.GetCustomerById(customerId);
        }

        [HttpPost("CreateCustomer")]
        public IActionResult CreateCustomer([FromBody] Customer customer)
        {
            _customerService.CreateCustomer(customer);
            return Ok("Customer created successfully!!");
        }

        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(int customerId)
        {
            _customerService.DeleteCustomer(customerId);
            return Ok("Customer deleted successfully!!");
        }

        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Customer updated successfully!!");
        }
    }
}

//POSTMAN tool - API Testing tool


