using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4_TP2.Pages.CityManager
{
    public class CityListModel : PageModel
    {
        public List<string> Cities { get; } = new()
    {
        "Rio de Janeiro",
        "São Paulo",
        "Brasília",
        "Salvador",
        "Florianópolis",
        "Foz do Iguaçu",
        "Manaus"
    };

        public void OnGet() { }
    }
}