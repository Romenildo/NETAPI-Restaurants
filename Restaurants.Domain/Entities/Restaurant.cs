namespace Restaurants.Domain.Entities
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = default!;
        public string Category { get; set; } = default!;
        public bool HasDelivery { get; set; }

        public string? ContactEmail { get; set; }
        public string? ContactNumber { get; set; }

        public virtual Address? Address { get; set; }
        public virtual List<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
