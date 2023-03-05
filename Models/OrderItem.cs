using System.ComponentModel.DataAnnotations.Schema;

namespace nooblion_commerce_api.Models
{
    public class OrderItem
    {
        //Look up table that stores purchased items and which order it was purchased under
        public int Id { get; set; }

        //test
        [ForeignKey("Product")]
        public required int ProductId { get; set; } //FK


        [ForeignKey("Order")]
        public required int OrderId { get; set; }

        public required int Quantity { get; set; }
    }
}
