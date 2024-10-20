using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrainBox.Pages.Quiz
{
    [Authorize]
    public class QuizSelectionModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
