
using PinewoodUI.Models;
using PinewoodUI.Helpers;
using PinewoodUI.Services;

namespace PinewoodUI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/find";

        public CustomerService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<Customer>> Find()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAsync<List<Customer>>();
        }

       
    }
}