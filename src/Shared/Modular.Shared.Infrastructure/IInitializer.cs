using System.Threading.Tasks;

namespace Modular.Shared.Infrastructure;

public interface IInitializer
{
    Task InitAsync();
}