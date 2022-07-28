using System.Threading.Tasks;
using Modular.Shared.Abstractions.Messaging;

namespace Modular.Shared.Infrastructure.Messaging.Outbox;

public interface IOutboxBroker
{
    bool Enabled { get; }
    Task SendAsync(params IMessage[] messages);
}