using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DR4_TP2.Pages.CityManager
{
    public class CreateCityValidationModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();

        public bool IsSubmitted { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
            [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
            [Display(Name = "Nome da Cidade")]
            public string CityName { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public void OnPost()
        {
            IsSubmitted = true;
            if (!ModelState.IsValid)
                return;
            // Dados válidos — pode persistir, redirecionar
        }
    }
}