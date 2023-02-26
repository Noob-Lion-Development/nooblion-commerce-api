namespace nooblion_commerce_api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderCompleted { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        //Eventually these will be more standard like ISO codes for the country that will be stored in another table
        public required string Country { get; set; }
        public required string Street { get; set; }
        public required string City { get; set; }
    }
}
