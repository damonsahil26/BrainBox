using Microsoft.AspNetCore.Identity;

namespace BrainBox.Models
{
    public class Player : IdentityUser
    {
        public int TotalMatchesPlayed { get; set; }
        public int TotalMatchesWon { get; set; }
    }
}
