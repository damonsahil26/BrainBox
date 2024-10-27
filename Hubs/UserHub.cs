using Microsoft.AspNetCore.SignalR;

namespace BrainBox.Hubs
{
    public class UserHub : Hub
    {
        public static int TotalActiveUsers { get; set; } = 0;

        public override async Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                TotalActiveUsers++;
                await Clients.All.SendAsync("TotalActiveUsers" , TotalActiveUsers);
            }

        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                TotalActiveUsers--;
                await Clients.All.SendAsync("TotalActiveUsers", TotalActiveUsers);
            }
        }
    }
}
