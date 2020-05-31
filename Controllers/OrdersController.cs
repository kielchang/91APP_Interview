using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _91APP_Interview.Models;

namespace _91APP_Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderDbContext _context;

        public OrdersController(OrderDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders
                .Include(o => o.Product)
                .ToListAsync();
        }

        // GET: api/Orders/Shipped
        [HttpPut("Shipped")]
        public async Task<ActionResult<IEnumerable<Order>>> ShippedOrders(string[] ids)
        {
            var orders = await _context.Orders.Where(o => ids.Contains(o.Id)).ToListAsync();
            foreach (var order in orders) 
            {
                order.Status = "To be shipped";
            }

            _context.SaveChanges();

            return NoContent();
        }

        private bool OrderExists(string id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
