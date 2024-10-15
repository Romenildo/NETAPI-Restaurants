using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;

namespace Restaurants.Infraestructure.Persistence
{
    internal class RestaurantsDbContext(DbContextOptions<RestaurantsDbContext> options) : DbContext(options)
    {

        //cria o dbset para manipular suas tabelas
        internal DbSet<Restaurant> Restaurants { get; set; }
        internal DbSet<Dish> Dishes { get; set; }

    }
}
