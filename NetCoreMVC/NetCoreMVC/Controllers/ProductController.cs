using Microsoft.AspNetCore.Mvc;
using MyAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAppMVC.Controllers
{
    [Route("san-pham")]
    public class ProductController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(int? categoryId)
        {
            // Danh mục
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Quần áo" },
                new Category { Id = 2, Name = "Túi xách" },
                new Category { Id = 3, Name = "Đồng hồ" },
                new Category { Id = 4, Name = "Ti vi" },
                new Category { Id = 5, Name = "Tủ lạnh" },
                new Category { Id = 6, Name = "Máy bơm" },
                new Category { Id = 7, Name = "Quạt điện" },
                new Category { Id = 8, Name = "Lò sưởi" }
            };

            // Sản phẩm
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Bộ đồ bơi cho trẻ em nam",
                    Image = "/images/sp1.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em nam chất lượng cao.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 2,
                    Name = "Bộ đồ bơi cho trẻ em nữ",
                    Image = "/images/sp2.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em nữ.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 3,
                    Name = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi",
                    Image = "/images/sp3.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi trẻ em từ 3 đến 5 tuổi.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 4,
                    Name = "Bộ đồ bơi cho trẻ em thời trang",
                    Image = "/images/sp4.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi thời trang.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 5,
                    Name = "Túi thời trang màu mới 2021",
                    Image = "/images/sp5.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 2,
                    Description = "Túi thời trang cao cấp.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 6,
                    Name = "Túi thời trang da cá sấu",
                    Image = "/images/sp6.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 2,
                    Description = "Túi da cá sấu thời trang.",
                    Status = true,
                    CreatedAt = DateTime.Now
                }
            };

            // Nếu có chọn danh mục thì lọc
            if (categoryId.HasValue)
            {
                products = products
                    .Where(x => x.CategoryId == categoryId.Value)
                    .ToList();
            }

            var model = new ProductViewModel
            {
                Products = products,
                Categories = categories
            };

            return View(model);
        }
        [HttpGet("chi-tiet/{id}")]
        public IActionResult Detail(int id)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Bộ đồ bơi cho trẻ em nam",
                    Image = "/images/sp1.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em nam chất lượng cao.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 2,
                    Name = "Bộ đồ bơi cho trẻ em nữ",
                    Image = "/images/sp2.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em nữ.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 3,
                    Name = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi",
                    Image = "/images/sp3.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi trẻ em từ 3 đến 5 tuổi.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 4,
                    Name = "Bộ đồ bơi cho trẻ em thời trang",
                    Image = "/images/sp4.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi thời trang.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 5,
                    Name = "Túi thời trang màu mới 2021",
                    Image = "/images/sp5.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 2,
                    Description = "Túi thời trang cao cấp.",
                    Status = true,
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 6,
                    Name = "Túi thời trang da cá sấu",
                    Image = "/images/sp6.jpg",
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 2,
                    Description = "Túi da cá sấu thời trang.",
                    Status = true,
                    CreatedAt = DateTime.Now
                }
            };

            var product = products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}