using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4_TP2.Pages.CountryManager
{
    public class CreateMultipleCountriesModel : PageModel
    {
        [BindProperty]
        public List<InputModel> Countries { get; set; } = new();

        public List<InputModel> SubmittedCountries { get; set; } = new();

        public class InputModel
        {
            public string CountryName { get; set; } = string.Empty;
            public string CountryCode { get; set; } = string.Empty;
        }

        public void OnGet()
        {
            // Inicializa com 5 entradas vazias
            for (int i = 0; i < 5; i++)
                Countries.Add(new InputModel());
        }

        public void OnPost()
        {
            SubmittedCountries = Countries
                .Where(c => !string.IsNullOrWhiteSpace(c.CountryName))
                .ToList();
        }
    }
}
