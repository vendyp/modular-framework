using Modular.Shared.Abstractions.Messaging;

namespace Modular.Shared.Infrastructure.Messaging.Contexts;

public interface IMessageContextRegistry
{
    void Set(IMessage message, IMessageContext context);
}