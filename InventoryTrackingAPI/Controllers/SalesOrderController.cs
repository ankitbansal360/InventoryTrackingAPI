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
    public class SalesOrderController : ControllerBase
    {
        private readonly SupplierService _supplierService;
        public SalesOrderController(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet("GetAllSupplier")]
        public IEnumerable<Supplier> GetAllSupplier()
        {
            return _supplierService.GetAllSupplier();
        }
        [HttpGet("GetSupplierById")]
        public Supplier GetSupplier(int supplierId)
        {
            return _supplierService.GetSupplier(supplierId);
        }

        [HttpPost("AddSupplier")]
        public IActionResult AddSupplier([FromBody] Supplier supplier)
        {
            _supplierService.AddSupplier(supplier);
            return Ok("Supplier created successfully!!");
        }

        [HttpDelete("DeleteSupplier")]
        public IActionResult DeleteSupplier(int customerId)
        {
            _supplierService.DeleteSupplier(customerId);
            return Ok("Supplier deleted successfully!!");
        }

        [HttpPut("UpdateSupplier")]
        public IActionResult UpdateSupplier([FromBody] Supplier supplier)
        {
            _supplierService.UpdateSupplier(supplier);
            return Ok("Supplier updated successfully!!");
        }
    }
}

//POSTMAN tool - API Testing tool


