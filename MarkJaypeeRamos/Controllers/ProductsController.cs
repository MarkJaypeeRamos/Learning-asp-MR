using System.Collections.Generic;
using MarkJaypeeRamos.Models;
using MarkJaypeeRamos.Services;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace MarkJaypeeRamos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductServices productService)
        {
            ProductService = productService;
        }

        public JsonFileProductServices ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }


        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery]string ProductId, 
            [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}