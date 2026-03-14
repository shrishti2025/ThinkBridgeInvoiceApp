using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {
            var items = new List<Item>
            {
                new Item { Name = "Widget A", Price = 19.99 },
                new Item { Name = "Widget B", Price = 29.99 }
            };
            return Ok(new { items });
        }

        public class Item
        {
            public string Name { get; set; } = "";
            public double Price { get; set; }
        }
    }
}