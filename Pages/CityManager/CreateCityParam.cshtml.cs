using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4_TP2.Pages.CityManager
{
    public class CreateCityParamModel : PageModel
    {
        public string SubmittedCity { get; set; } = string.Empty;

        public void OnGet() { }

        public void OnPost(string cityName)
        {
            SubmittedCity = cityName;
        }
    }
}
