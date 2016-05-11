using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public class Greeter : IGreeter
    {
        private readonly string greeting;

        public Greeter(IConfiguration configuration)
        {
            greeting = configuration["greeting"];
        }

        public string GetGreeting() => greeting;
    }
}