using System.Collections.Generic;

namespace MyAppMVC.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }
    }
}