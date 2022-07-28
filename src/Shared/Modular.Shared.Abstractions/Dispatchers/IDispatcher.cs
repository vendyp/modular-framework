using System.Threading;
using System.Threading.Tasks;
using Modular.Shared.Abstractions.Commands;
using Modular.Shared.Abstractions.Events;
using Modular.Shared.Abstractions.Queries;

namespace Modular.Shared.Abstractions.Dispatchers;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}