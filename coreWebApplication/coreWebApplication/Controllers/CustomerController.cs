﻿using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace coreWebApplication.Controllers
{
    public class CustomerController : Controller
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
            return View();
        }
//        [Route("~/")]
        [Route("/sample/message")]

        public IActionResult Message()
        {
            return View();
        }

    }
}
