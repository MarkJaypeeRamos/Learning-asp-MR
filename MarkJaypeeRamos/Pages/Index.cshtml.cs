using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarkJaypeeRamos.Models;
using MarkJaypeeRamos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MarkJaypeeRamos.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductServices ProductServices;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductServices productServices)
        {
            _logger = logger;
            ProductServices = productServices;
        }

        public void OnGet()
        {
            Products = ProductServices.GetProducts();
        }
    }
}
