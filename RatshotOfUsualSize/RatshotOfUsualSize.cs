using System.Reflection;
using JetBrains.Annotations;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace RatshotOfUsualSize;

[Injectable(TypePriority = OnLoadOrder.TraderRegistration - 1), UsedImplicitly]
public class RatshotOfUsualSize(WTTServerCommonLib.WTTServerCommonLib wtt) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        var assembly = Assembly.GetExecutingAssembly();
        await wtt.CustomItemServiceExtended.CreateCustomItems(assembly);
        await wtt.CustomAssortSchemeService.CreateCustomAssortSchemes(assembly);
    }
}