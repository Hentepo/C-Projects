﻿ using Microsoft.Extensions.Configuration;
using System.IO;


namespace AspNetCoreWebApiClientProject.Models
{
    public class Product
    {

    public int ProductId {  get; set; }
    public string? Name { get; set; }

    public double Price { get; set; }
    }

}
