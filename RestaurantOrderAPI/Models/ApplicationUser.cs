using Microsoft.AspNetCore.Identity;

namespace RestaurantOrderAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Dish { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}