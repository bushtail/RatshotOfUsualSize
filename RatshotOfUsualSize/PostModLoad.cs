using JetBrains.Annotations;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace RatshotOfUsualSize;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 2), UsedImplicitly]
public class PostModLoad : IOnLoad
{
    public Task OnLoad()
    {
        throw new NotImplementedException();
    }
}