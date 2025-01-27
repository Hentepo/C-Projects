using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Newtonsoft.Json;
using System.Text;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public async Task<ActionResult> Index()
        {
            List<Product> products = new List<Product>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:5108/api/Products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);

                }
            }
            return View(products);
        }

        // GET: ProductController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Product product = null;

            // Call the API to get the product details
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"http://localhost:5108/api/Products/{id}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Deserialize the response into a Product object
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        product = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                    else
                    {
                        // Handle the case where the product is not found (e.g., 404)
                        ModelState.AddModelError("", "Product not found.");
                    }
                }
            }

            // If product is null, redirect to the Index page or show an error page
            if (product == null)
            {
                return RedirectToAction(nameof(Index)); // Or return View("Error") for a custom error page
            }

            // Return the product details view, passing the product object
            return View(product);
        }



        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            try
            {
                // Validate the product
                if (ModelState.IsValid)
                {
                    // Create a new HttpClient instance
                    using (var client = new HttpClient())
                    {
                        // Set the base address of the API
                        client.BaseAddress = new Uri("http://localhost:5108");

                        // Serialize the product object to JSON
                        var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

                        // Send POST request to the API to create the product
                        var response = await client.PostAsync("api/Products", content);

                        if (response.IsSuccessStatusCode)
                        {
                            // Redirect to the Index action if successful
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            // Add error message if the request failed
                            ModelState.AddModelError("", "Error creating product. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error if needed and add a general error message
                ModelState.AddModelError("", "An error occurred while creating the product.");
            }

            // Return to the Create view with error messages if any
            return View(product);
        }


        // GET: ProductController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Product product = null;

            // Call the API to get the product details for editing
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:5108/api/Products/{id}");
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
                else
                {
                    return RedirectToAction(nameof(Index)); // Redirect if the product is not found
                }
            }

            // Pass the product to the view for editing
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Product product)
        {
            try
            {
                // Send the updated product data to the API
                using (var client = new HttpClient())
                {
                    var jsonData = JsonConvert.SerializeObject(product);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync($"http://localhost:5108/api/Products/{id}", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while updating the product: " + ex.Message);
            }

            // If something goes wrong, return the user to the Edit view
            return View(product);
        }


        // GET: ProductController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            Product product = null;

            // Fetch the product details for confirmation
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:5108/api/Products/{id}");
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
                else
                {
                    return RedirectToAction(nameof(Index)); // Redirect if the product is not found
                }
            }

            return View(product); // Show the Delete confirmation page
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Product product)
        {
            try
            {
                // Call the API to delete the product
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"http://localhost:5108/api/Products/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while deleting the product: " + ex.Message);
            }

            return RedirectToAction(nameof(Index)); // Redirect regardless to prevent repeated attempts
        }

    }
}























//{
//    public class ProductController : Controller
//    {
//        // GET: ProductController
//        public async Task<ActionResult> Index()
//        {
//            List<Product> products = new List<Product>();
//            using (var client = new HttpClient())
//            {
//                using (var response = await client.GetAsync("http://localhost:5108/api/Products"))
//                {
//                    string apiResponse = await response.Content.ReadAsStringAsync();
//                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);

//                }
//            }
//            return View(products);
//        }

//        // GET: ProductController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: ProductController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ProductController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ProductController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: ProductController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ProductController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: ProductController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
