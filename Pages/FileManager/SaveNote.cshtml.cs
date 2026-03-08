using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DR4_TP2.Pages.FileManager
{
    public class SaveNoteModel : PageModel
    {
        private readonly IWebHostEnvironment _env;

        public SaveNoteModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public string SavedFileName { get; set; } = string.Empty;

        public class InputModel
        {
            [Required(ErrorMessage = "O título é obrigatório.")]
            [Display(Name = "Título")]
            public string Title { get; set; } = string.Empty;

            [Required(ErrorMessage = "O conteúdo é obrigatório.")]
            [MinLength(5, ErrorMessage = "O conteúdo deve ter pelo menos 5 caracteres.")]
            [Display(Name = "Conteúdo")]
            public string Content { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public void OnPost()
        {
            if (!ModelState.IsValid)
                return;

            var filesDir = Path.Combine(_env.WebRootPath, "files");
            Directory.CreateDirectory(filesDir);

            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var fileName = $"note-{timestamp}.txt";
            var filePath = Path.Combine(filesDir, fileName);

            var content = $"Título: {Input.Title}\nData: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n\n{Input.Content}";
            System.IO.File.WriteAllText(filePath, content);

            SavedFileName = fileName;
        }
    }
}