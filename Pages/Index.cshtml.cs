using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrainBox.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPostRedirectToPage()
        {
            return RedirectToPage("/Quiz/QuizSelection"); // Change "AnotherPage" to the page you want to redirect to
        }
        public void OnGet()
        {

        }
    }
}
