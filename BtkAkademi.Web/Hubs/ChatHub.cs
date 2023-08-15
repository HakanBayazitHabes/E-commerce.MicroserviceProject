using BtkAkademi.Web.Models;
using BtkAkademi.Web.ViewModels;
using Microsoft.AspNetCore.SignalR;

namespace BtkAkademi.Web.Hubs
{
    public class ChatHub : Hub
    {
        private static string _adminConnectionId;

        public override Task OnConnectedAsync()
        {
            if (Context.User.IsInRole("Admin"))
            {
                _adminConnectionId = Context.ConnectionId;
            }

            return base.OnConnectedAsync();
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendMessageToAdmin(string user, string message)
        {
            await Clients.Client(_adminConnectionId).SendAsync("ReceiveMessageAdmin", user, message);
        }

        public async Task SendImage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveImage", user, message);
        }

        public async Task SendImageToAdmin(string user, string message)
        {
            await Clients.Client(_adminConnectionId).SendAsync("ReceiveImageAdmin", user, message);
        }

        public async Task SendSound(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveSound", user, message);
        }

        public async Task SendSoundToAdmin(string user, string message)
        {
            await Clients.Client(_adminConnectionId).SendAsync("ReceiveSoundtoadmin", user, message);
        }


    }


}
