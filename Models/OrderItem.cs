namespace nooblion_commerce_api.Models
{
    public class OrderItem
    {
        //Look up table that stores purchased items and which order it was purchased under
        public int Id { get; set; }
        public required int ProductId { get; set; } //FK
        public required Product Product { get; set; }
        public required int OrderId { get; set; }
        public required Order Order { get; set; }
        public required int Quantity { get; set; }
    }
}
