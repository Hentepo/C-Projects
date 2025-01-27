using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace WebApi.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string? Name { get; set; }

        public double Price { get; set; }
    }

}
