using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DR4_TP2.Pages.CountryManager
{
    public class CreateCountryCustomValModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();

        public bool IsSuccess { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O nome do país é obrigatório.")]
            [MinLength(2, ErrorMessage = "Nome muito curto.")]
            [Display(Name = "Nome do País")]
            public string CountryName { get; set; } = string.Empty;

            [Required(ErrorMessage = "O código ISO é obrigatório.")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve ter exatamente 2 letras.")]
            [Display(Name = "Código ISO (2 letras)")]
            public string CountryCode { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public void OnPost()
        {
            // Validação: primeira letra deve ser a mesma
            if (!string.IsNullOrEmpty(Input.CountryName) && !string.IsNullOrEmpty(Input.CountryCode))
            {
                var firstLetterName = char.ToUpper(Input.CountryName[0]);
                var firstLetterCode = char.ToUpper(Input.CountryCode[0]);

                if (firstLetterName != firstLetterCode)
                {
                    ModelState.AddModelError("Input.CountryCode",
                        $"O código deve começar com '{firstLetterName}', igual ao nome do país.");
                }
            }

            if (!ModelState.IsValid)
                return;

            IsSuccess = true;
        }
    }
}
