using System.Reflection;
using System.Text.Json;
using JetBrains.Annotations;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace RatshotOfUsualSize;

[Injectable(TypePriority = OnLoadOrder.TraderRegistration - 1), UsedImplicitly]
public class RatshotOfUsualSize(WTTServerCommonLib.WTTServerCommonLib wtt) : IOnLoad
{
    private static readonly JsonSerializerOptions _options = new() { WriteIndented = true };

    public async Task OnLoad()
    {
        var assembly = Assembly.GetExecutingAssembly();
        await wtt.CustomItemServiceExtended.CreateCustomItems(assembly);
        await wtt.CustomAssortSchemeService.CreateCustomAssortSchemes(assembly);
    }
}