using System.ComponentModel.DataAnnotations;

namespace CatalogManager.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public ICollection<ProductSupplier> ProductSuppliers { get; set; }
    = new List<ProductSupplier>();
        public Category Category { get; set; } = null!;
    }
}
