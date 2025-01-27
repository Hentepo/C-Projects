using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

public class DemoController : Controller
{
    public static List<Customer> customers = new List<Customer>()
    {
        new Customer() {Id = 101, Name = "John", Amount = 12000},
        new Customer() {Id = 102, Name = "John", Amount = 12000},
    };

    public IActionResult Index()
    {
        ViewBag.Message = "Customer Management System";
        ViewBag.CustomerCount = customers.Count();
        ViewBag.CustomerList = customers;
        return View();
    }
    public IActionResult Details()
    {
        ViewData["Message"] = "Customer Management System";
        ViewData["CustomerCount"] = customers.Count();
        ViewData["CustomerList"] = customers;
        return View();
    }

    public IActionResult Method1()
    {
        TempData["Message"] = "Customer Management System";
        TempData["CustomerCount"] = customers.Count();
        TempData["CustomerList"] = customers;
        return View();
    }
    public IActionResult Method2()
    {
        if (TempData["Message"] == null)
            return RedirectToAction("Index");
        TempData["Message"] = TempData["Message"].ToString();
        return View();
    }

    public IActionResult Login()
    {
        HttpContext.Session.SetString("username", "Henri");
        return RedirectToAction("Success");
    }
    public IActionResult Success()
    {
        ViewBag.Username = HttpContext.Session.GetString("username");
        return View();
    }
    public IActionResult Logout()
    {
        HttpContext.Session.Remove("Username");
        return RedirectToAction("Index");
    }

    //Request Url: http://localhost:5219/Demo/QueryTest
    //Request Url: http://localhost:5219/Demo/QueryTest?name=Henri


    public IActionResult QueryTest()
    {
        string name = "King Kochhar";
        if (!String.IsNullOrEmpty(HttpContext.Request.Query[name]))
            name = HttpContext.Request.Query["name"];
        ViewBag.Name = name;
        return View();
    }



}
