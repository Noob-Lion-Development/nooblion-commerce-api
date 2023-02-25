using System.ComponentModel.DataAnnotations;

namespace nooblion_commerce_api.Models
{
    public class Product
    {
        public int Id { get; set; } // PK
        public required string ImageURL { get; set; } //denoted as nullable
        public float Price { get; set; }
        public required string Details { get; set; }
        public required string Name { get; set; }
    }
}
