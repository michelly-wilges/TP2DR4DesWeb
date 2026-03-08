using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4_TP2.Pages;
public class ExerciseMenuItem
{
    public int Number { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Page { get; set; } = "";
}

public class IndexModel : PageModel
{
    public List<ExerciseMenuItem> Exercises { get; } = new()
    {
        new() { Number = 1,  Title = "Razor Page com PageModel e BindProperty",    Description = "Formulário de cadastro de cidade com model binding via [BindProperty].",              Page = "/CityManager/CreateCity" },
        new() { Number = 2,  Title = "Model Binding via Handler Parameters",        Description = "Cadastro de cidade usando parâmetro direto no método OnPost.",                       Page = "/CityManager/CreateCityParam" },
        new() { Number = 3,  Title = "Validação Server-side com Data Annotations",  Description = "Validação do nome da cidade com [Required] e [MinLength(3)] no servidor.",           Page = "/CityManager/CreateCityValidation" },
        new() { Number = 4,  Title = "Validação Client-side com Tag Helpers",       Description = "Mensagens de erro antes do envio usando asp-validation-for e scripts.",              Page = "/CityManager/CreateCityClientVal" },
        new() { Number = 5,  Title = "Objeto Complexo — Cadastro de País",          Description = "Formulário com objeto Country contendo CountryName e CountryCode.",                  Page = "/CountryManager/CreateCountry" },
        new() { Number = 6,  Title = "Validação do Código ISO do País",             Description = "Valida que o código do país tenha exatamente 2 caracteres.",                         Page = "/CountryManager/CreateCountryValidated" },
        new() { Number = 7,  Title = "Múltiplos Registros Simultâneos",             Description = "Submissão de 5 países em um único formulário usando List<InputModel>.",             Page = "/CountryManager/CreateMultipleCountries" },
        new() { Number = 8, Title = "Roteamento com Parâmetros na URL", Description = "Página de detalhes da cidade com parâmetro via @page \"{cityName}\".", Page = "/CityManager/CityList" },
        new() { Number = 9,  Title = "Links com Tag Helpers de Roteamento",         Description = "Lista de cidades com links dinâmicos usando asp-route-cityName.",                   Page = "/CityManager/CityList" },
        new() { Number = 10, Title = "Manipulação de Arquivos — Escrita",           Description = "Salva texto em arquivo .txt no wwwroot/files com link para download.",              Page = "/FileManager/SaveNote" },
        new() { Number = 11, Title = "Manipulação de Arquivos — Leitura",           Description = "Lista e exibe o conteúdo dos arquivos .txt salvos.",                                Page = "/FileManager/ListNotes" },
        new() { Number = 12, Title = "Validação Customizada com ModelState",        Description = "País e código devem começar com a mesma letra, validado via ModelState.",           Page = "/CountryManager/CreateCountryCustomVal" },
    };
}

