using Api.Chat.Models;
using Microsoft.AspNetCore.SignalR;

namespace Api.Chat.Hubs;

public class HubProvider : Hub<IHubProvider>
{
    public async Task SendMessageAsync(Message message)
    {
        await Clients.All.ReceivedMessageAsync(message);
    }
}
