using Microsoft.AspNetCore.SignalR;
using System.Runtime.ExceptionServices;
using System.Text.Json;


namespace SignalRChat.Hubs
{
    public class msg {
        public string Last { get; set; }
        public string First { get; set; }

        public bool Important { get; set; }
    }

    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            string t = "{\"user\" : \"Harry\", \"text\": \"Hallo\"}";

            var m = new msg {
                Last = "Schmidt",
                First = "Harald",
                Important = true
            };

            Console.Write(JsonSerializer.Serialize(m));
            await Clients.All.SendAsync("ReceiveMessage", user, JsonSerializer.Serialize(m));
        }
    }

}