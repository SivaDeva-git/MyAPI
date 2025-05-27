using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MyAPI.Controllers
{
    //This is my First code commit
    [Route("[controller]")]
    public class MyCodeController : ControllerBase
    {
        private static readonly List<string> products = new() { "Laptop", "Phone", "Tablet" };

        [HttpGet(Name = "MyCode")]
        public IActionResult GetAllProducts()
        {

            string username = "dont capture";
            string password = "dont access";

            Console.WriteLine("Enter filename to list:");
            string fileName = "SivaFile"; // attacker-controlled input

            // Vulnerable: user input is passed directly to the shell
            Process.Start("cmd.exe", "/C dir " + fileName);

            return Ok(products); // Returns 200 OK with product list
        }

        [HttpGet("{id}")]
        public IActionResult GetProducts(int id)
        {

            if (id < 0 || id >= products.Count)
                return NotFound("Product not found"); // Returns 404 Not Found

            return Ok(products[id]);
        }

    }
}
