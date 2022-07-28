using System;
using Modular.Shared.Abstractions.Time;

namespace Modular.Shared.Infrastructure.Time;

public class UtcClock : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}