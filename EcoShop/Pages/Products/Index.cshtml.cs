using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoShop.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration _configuration)
        {
            this._configuration = _configuration;
        }

        public string Heading { get; set; } // tekst wyswietlany na stronie /Products/Index
        public string Message { get; set; } 
        public void OnGet()
        {
            Heading = "List of Eco products";
            Message = _configuration["Message"];
        }
    }
}
