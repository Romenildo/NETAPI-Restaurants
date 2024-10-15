﻿namespace Restaurants.Domain.Entities
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
    }
}
