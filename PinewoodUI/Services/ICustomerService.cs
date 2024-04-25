using PinewoodUI.Models;

namespace PinewoodUI.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> Find();
    }
}
