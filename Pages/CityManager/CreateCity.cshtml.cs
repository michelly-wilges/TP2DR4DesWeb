using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4_TP2.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public string CityName { get; set; } = string.Empty;

        public void OnGet() { }

        public void OnPost()
        {
            // Preenchido automaticamente [BindProperty]
        }
    }
}
