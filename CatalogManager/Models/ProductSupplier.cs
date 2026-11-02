using System.ComponentModel.DataAnnotations;


namespace CatalogManager.Models
{
    public class ProductSupplier
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }

        public decimal PurchasePrice { get; set; } = 0;
        public string? SupplierProductName { get; set; } = string.Empty;

        public Product Product { get; set; } = null!;
        public Supplier Supplier { get; set; } = null!;
    }
}
