using System;

namespace Modular.Shared.Abstractions.Time;

public interface IClock
{
    DateTime CurrentDate();
}