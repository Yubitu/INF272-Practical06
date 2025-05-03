using System.Collections.Generic;

namespace ProductList.Models
    {
    public class ProductViewModel
        {
        public int SelectedCategoryId { get; set; }
        public int SelectedProductId { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public int SelectedSupplierId { get; set; }
        public string Value { get; set; }
        public string Serial { get; set; }
    }
}