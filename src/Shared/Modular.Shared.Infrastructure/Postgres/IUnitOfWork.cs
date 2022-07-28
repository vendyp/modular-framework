using System;
using System.Threading.Tasks;

namespace Modular.Shared.Infrastructure.Postgres;

public interface IUnitOfWork
{
    Task ExecuteAsync(Func<Task> action);
}