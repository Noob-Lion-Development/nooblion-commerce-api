using System.ComponentModel.DataAnnotations;

namespace nooblion_commerce_api.Models
{
    public class Product
    {
        public int Id { get; set; } // PK
        public string? ImageURL { get; set; } //denoted as nullable
        public float Price { get; set; }
        public string? Details { get; set; }
        public string? Name { get; set; }
    }
}
