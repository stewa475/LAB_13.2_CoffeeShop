using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using LAB_11._2_CoffeeShop.Models;

namespace LAB_11._2_CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        IConfiguration ConfigRoot;
        SqlConnection connection;

        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            connection = new SqlConnection(ConfigRoot.GetConnectionString("coffeeShopDB"));
        }

        public IActionResult Index()
        {
            string queryString = "SELECT * FROM Products";
            var Products = connection.Query<Product>(queryString);

            ViewData["Products"] = Products;

            return View("ProductsIndex");
        }
    }
}