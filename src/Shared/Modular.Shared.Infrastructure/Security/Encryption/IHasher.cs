namespace Modular.Shared.Infrastructure.Security.Encryption;

public interface IHasher
{
    string Hash(string data);
}