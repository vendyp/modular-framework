using System;
using Modular.Shared.Abstractions.Exceptions;

namespace Modular.Shared.Infrastructure.Exceptions;

public interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}