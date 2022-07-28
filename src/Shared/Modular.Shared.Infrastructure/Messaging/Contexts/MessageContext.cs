using System;
using Modular.Shared.Abstractions.Contexts;
using Modular.Shared.Abstractions.Messaging;

namespace Modular.Shared.Infrastructure.Messaging.Contexts;

public class MessageContext : IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }

    public MessageContext(Guid messageId, IContext context)
    {
        MessageId = messageId;
        Context = context;
    }
}