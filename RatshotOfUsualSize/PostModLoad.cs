using System.Reflection;
using JetBrains.Annotations;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace RatshotOfUsualSize;

[Injectable(TypePriority = OnLoadOrder.TraderRegistration - 1), UsedImplicitly]
public class PostModLoad(WTTServerCommonLib.WTTServerCommonLib wttServerCommonLib) : IOnLoad
{
    public async Task OnLoad()
    {
        var assembly = Assembly.GetExecutingAssembly();
        await wttServerCommonLib.CustomItemServiceExtended.CreateCustomItems(assembly);
        await wttServerCommonLib.CustomAssortSchemeService.CreateCustomAssortSchemes(assembly);
    }
}