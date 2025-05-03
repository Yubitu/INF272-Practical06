using ProductList.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductList.Controllers
    {
    public class ProductController : Controller
        {
        public ActionResult Index()
            {
            var viewModel = new ProductViewModel
                {
                Categories = ProductRepository.GetCategories(),
                Products = ProductRepository.GetProducts(),
                Suppliers = ProductRepository.GetSuppliers(),
            };
            return View(viewModel);
            }

        public ActionResult GetProductsByCategory(int categoryId)
            {
            var products = ProductRepository.GetProducts()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new { p.Id, p.Name });

            var productNames = new List<string>();
            var productIds = new List<int>();
            foreach (var product in products)
                {
                productNames.Add(product.Name);
                productIds.Add(product.Id);
                }

            return Content(
                string.Format("{0};{1}", string.Join(",", productNames), string.Join(",", productIds)),
                "text/plain"
            );
            }

        public ActionResult AddProduct(int productId, string productName)
            {
            // Here you can add the product to your data store or perform other actions
            return Content("OK", "text/plain");
            }

        //Duplicating the code for GetProductsByCategory
        public ActionResult GetCategoriesBySupplier(int supplierId)
        {
            var categories = ProductRepository.GetCategories()
                .Where(c => c.SupplierId == supplierId)
                .Select(c => new { c.Id, c.Name });

            var categoryNames = new List<string>();
            var categoryIds = new List<int>();

            foreach (var category in categories)
            {
                categoryNames.Add(category.Name);
                categoryIds.Add(category.Id);
            }

            return Content(
                string.Format("{0};{1}", string.Join(",", categoryNames), string.Join(",", categoryIds)),
                "text/plain"
            );
        }

    }
}