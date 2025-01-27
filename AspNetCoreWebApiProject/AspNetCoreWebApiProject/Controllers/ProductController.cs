//using AspNetCoreWebApiProject.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;


//namespace AspNetCoreWebApiProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        public static List<Product> products = new List<Product>()
//        {
//            new Product() {ProductId  = 1}, Name = "Product One", Price = 12000 },
//        };

//        [HttpGet]

//        public List<Product> GetProducts()
//        {
//            return products;
//        }
//    [HttpPost]

//    public void PostProduct()
//    {
//        products.Add(new Product() { ProductId = 4, Name = "Product Four", Price = 12000});

//    }


//    public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}
