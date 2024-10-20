using BrainBox.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrainBox.Pages.Quiz
{
    [Authorize]
    public class QuizSelectionModel : PageModel
    {
        [BindProperty]
        public UserSelectionDto UserSelection { get; set; }
        public IActionResult OnPost()
        {
            // Redirect to the next page with the form data as a query string
            return RedirectToPage("/Quiz/QuizMatch", new { category = UserSelection.Category, type = UserSelection.Type, difficulty = UserSelection.Difficulty, noOfQuestions= UserSelection.NoofQuestions });
        }
    }
}
