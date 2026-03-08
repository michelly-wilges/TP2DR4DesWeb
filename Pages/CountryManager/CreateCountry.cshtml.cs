using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace DR4_TP2.Pages.CountryManager
{
    public class Country
        {
        public string CountryName { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
    }
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();

        public Country? CreatedCountry { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O nome do país é obrigatório.")]
            [Display(Name = "Nome do País")]
            public string CountryName { get; set; } = string.Empty;

            [Required(ErrorMessage = "O código do país é obrigatório.")]
            [Display(Name = "Código ISO (2 letras)")]
            public string CountryCode { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public void OnPost()
        {
            if (!ModelState.IsValid)
                return;

            CreatedCountry = new Country
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode.ToUpper()
            };
        }
    }
}
