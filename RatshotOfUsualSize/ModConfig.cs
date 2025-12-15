using JetBrains.Annotations;

namespace RatshotOfUsualSize;

[UsedImplicitly]
public record ModConfig
{
    public bool EnableUnbalancedAmmo { get; set; } = false;
}