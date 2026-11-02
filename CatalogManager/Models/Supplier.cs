using System.ComponentModel.DataAnnotations;


namespace CatalogManager.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();
    }
}
