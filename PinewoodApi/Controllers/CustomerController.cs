
using Microsoft.AspNetCore.Mvc;
using PinewoodApi.Models;

namespace PinewoodApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new Customer
            {
                CustomerId = index, 
                Accountno = 1,
                FirstName = "Mary",
                LastName = "Dobson",
                Email = "md@coldmail.com",
                IsActive = true
             
            })
            .ToArray();
        }
    }
}
