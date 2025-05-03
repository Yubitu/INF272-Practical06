using System.Collections.Generic;

namespace ProductList.Models
    {
    public class SimpleProduct
        {
        public int SimpleProductID { get; set; }
        public string SimpleProductName { get; set; }
        public List<SimpleProductSupplier> SimplePrices { get; set; }
        }
    }