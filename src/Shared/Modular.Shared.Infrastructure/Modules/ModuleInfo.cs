using System.Collections.Generic;

namespace Modular.Shared.Infrastructure.Modules;

public record ModuleInfo(string Name, IEnumerable<string> Policies);