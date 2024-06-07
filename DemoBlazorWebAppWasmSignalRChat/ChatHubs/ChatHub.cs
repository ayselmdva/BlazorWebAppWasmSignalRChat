using Microsoft.AspNetCore.SignalR;
using System.Data;

namespace DemoBlazorWebAppWasmSignalRChat.ChatHubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string userName, string message, DateTime date)=>await Clients.All.SendAsync("ReceiveMessage", userName, message, date);
    }
}
