using ProductList.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProductList.Controllers
    {
    public class SimpleProductController : Controller
        {
        public ActionResult SimpleProductAverages()
            {
            return View(SimpleListRepository.SimpleProducts);
            }

        public ActionResult SimpleSupplierProductAverage()
            {
            List<SimpleProductSupplier> simpleProductSuppliers = new List<SimpleProductSupplier>();
            foreach (SimpleProduct simpleProduct in SimpleListRepository.SimpleProducts)
                {
                simpleProductSuppliers.AddRange(simpleProduct.SimplePrices);
                }

            SimpleSupplierVM viewModel = new SimpleSupplierVM
                {
                SimpleSuppliers = SimpleListRepository.SimpleSuppliers,
                SimpleProductSuppliers = simpleProductSuppliers,
                };
            return View(viewModel);
            }
        }
    }