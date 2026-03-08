using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4_TP2.Pages.FileManager
{
    public class ListNotesModel : PageModel
    {
        private readonly IWebHostEnvironment _env;

        public ListNotesModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        public List<string> Files { get; set; } = new();
        public string SelectedFile { get; set; } = string.Empty;
        public string FileContent { get; set; } = string.Empty;

        public void OnGet(string? file)
        {
            var filesDir = Path.Combine(_env.WebRootPath, "files");
            Directory.CreateDirectory(filesDir);

            Files = Directory.GetFiles(filesDir, "*.txt")
                .Select(Path.GetFileName)
                .Where(f => f != null)
                .Select(f => f!)
                .OrderByDescending(f => f)
                .ToList();

            if (!string.IsNullOrEmpty(file) && Files.Contains(file))
            {
                SelectedFile = file;
                var filePath = Path.Combine(filesDir, file);
                FileContent = System.IO.File.ReadAllText(filePath);
            }
        }
    }
}