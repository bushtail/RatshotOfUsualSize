using System.Reflection;
using System.Text.Json;
using JetBrains.Annotations;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Helpers;
using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;
using SPTarkov.Server.Core.Services.Mod;

namespace RatshotOfUsualSize;

[Injectable(TypePriority = OnLoadOrder.TraderRegistration - 1), UsedImplicitly]
public class RatshotOfUsualSize(DatabaseService databaseService, CustomItemService customItemService, ModHelper modHelper, ISptLogger<RatshotOfUsualSize> logger) : IOnLoad
{
    private static ModConfig? _modConfig;
    private static readonly JsonSerializerOptions _options = new() { WriteIndented = true };
    public static ISptLogger<RatshotOfUsualSize>? Logger;
    public Task OnLoad()
    {
        Logger = logger;
        var itemsDb = databaseService.GetTables().Templates.Items;
        var path = modHelper.GetAbsolutePathToModFolder(Assembly.GetExecutingAssembly());

        if (!File.Exists($"{path}/config.json"))
        {
            _modConfig = new ModConfig();
            var json = JsonSerializer.Serialize(_modConfig, _options);
            File.WriteAllText($"{path}/config.json", json);
        }
        _modConfig = modHelper.GetJsonDataFromFile<ModConfig>(path, "config.json");
        
        foreach (var newItem in RatshotFactory.GetRatshotItems())
        {
            customItemService.CreateItemFromClone(newItem);
        }

        if (_modConfig.EnableUnbalancedAmmo)
        {
            foreach (var newUnbalancedItem in RatshotFactory.GetUnbalancedRatshotItems())
            {
                customItemService.CreateItemFromClone(newUnbalancedItem);
            }
        }
        
        if (CheckForWTTBackport(itemsDb))
        {
            customItemService.CreateItemFromClone(new Ammo_93x64());
            customItemService.CreateItemFromClone(new AmmoBox_93x64());
            customItemService.CreateItemFromClone(new Ammo_784x49());
            customItemService.CreateItemFromClone(new AmmoBox_784x49());
        }

        customItemService.CreateItemFromClone(new Ammo_9x18());
        return Task.CompletedTask;
    }

    private static bool CheckForWTTBackport(Dictionary<MongoId, TemplateItem> db)
    {
        return db.TryGetValue(CompatRefID.AMMO_BASE_93X64, out _) &&
               db.TryGetValue(CompatRefID.AMMOBOX_BASE_93X64, out _) &&
               db.TryGetValue(CompatRefID.AMMO_BASE_784X49, out _) &&
               db.TryGetValue(CompatRefID.AMMOBOX_BASE_784X49, out _);
    }
}