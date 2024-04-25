using PinewoodApi.Models;

namespace PinewoodApi.Endpoints
{
    public class LocationEndpointsConfig
    {
       
            private static readonly string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

            public static void AddEndpoints(WebApplication app)
            {
                app.MapGet("api/find", () =>
                {
                    var rng = new Random();
                    var customers = Enumerable.Range(1, 5).Select(index => new Customer
                    {
                        CustomerId = index,
                        Accountno = 1,
                        FirstName = "Mary",
                        LastName = "Dobson",
                        Email = "md@coldmail.com",
                        IsActive = true
                      
                    })
                    .ToArray();

                    return Results.Ok(customers);
                });
            }
        }
    }

