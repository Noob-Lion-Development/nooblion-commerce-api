using nooblion_commerce_api.Models;

namespace nooblion_commerce_api.DataObjects
{
    public class OrdersViewModel
    {
        public List<Order> Orders { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
