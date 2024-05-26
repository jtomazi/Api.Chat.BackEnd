using Api.Chat.Models;

namespace Api.Chat.Hubs;

public interface IHubProvider
{
    Task ReceivedMessageAsync(Message message);
}
