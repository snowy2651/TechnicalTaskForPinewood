using Microsoft.AspNetCore.Mvc;
using PinewoodUI.Services;

namespace PinewoodUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _service.Find();
            return View(customers);
        }

    }
}
