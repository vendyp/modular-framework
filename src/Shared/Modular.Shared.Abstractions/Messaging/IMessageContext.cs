using System;
using Modular.Shared.Abstractions.Contexts;

namespace Modular.Shared.Abstractions.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}