using Microsoft.AspNetCore.Identity;

namespace BrainBox.Models
{
    public class Player : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int TotalMatchesPlayed { get; set; }
        public int TotalMatchesWon { get; set; }
    }
}
