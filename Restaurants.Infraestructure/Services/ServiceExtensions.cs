using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Infraestructure.Persistence;

//Como restaurantDbContext pertence somente a indraestructure, para utilizar ele la na API
//So precisa colcoar ele dentro da função e chama-la lá
namespace Restaurants.Infraestructure.Services
{
    public static class ServiceExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("RestaurantsDb");
            services.AddDbContext<RestaurantsDbContext>(opt => 
            {
                opt.UseNpgsql(connectionString);
            });
        }
    }
}
