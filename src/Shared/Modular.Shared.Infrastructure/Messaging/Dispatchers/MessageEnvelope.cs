using Modular.Shared.Abstractions.Messaging;

namespace Modular.Shared.Infrastructure.Messaging.Dispatchers;

public record MessageEnvelope(IMessage Message, IMessageContext MessageContext);