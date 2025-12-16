using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public record Ammo_46x30 : NewItemFromCloneDetails
{
    public override MongoId? ItemTplToClone { get; set; } = ItemTpl.AMMO_46X30_FMJ_SX;

    public override TemplateItemProperties OverrideProperties { get; set; } = new()
    {
        Prefab = new Prefab
        {
            Path = "pdw/ammo_46x30_ratshot.bundle"
        },
        Name = "ammo_46x30_xx_rat",
        Damage = 10,
        ProjectileCount = 10,
        BuckshotBullets = 10,
        Weight = 0.075,
        AmmoAccr = 0,
        AmmoType = "buckshot",
        RicochetChance = 0,
        AmmoTooltipClass = "SoftTargets",
        ArmorDamage = 5,
        BallisticCoeficient = 0.025,
        BulletDiameterMilimeters = 1,
        PenetrationPower = 1,
        PenetrationChanceObstacle = 0.1,
        PenetrationDamageMod = 0.0,
        StaminaBurnPerDamage = 0.15,
        StackMaxSize = 50
    };

    public override string ParentId { get; set; } = ParentID.AMMO.ToString();
    public override string NewId { get; set; } = ModItemTpl.AMMO_46X30.ToString();
    public override double? FleaPriceRoubles { get; set; }
    public override double? HandbookPriceRoubles { get; set; }
    public override string HandbookParentId { get; set; } = ParentID.AMMO_HANDBOOK.ToString();
    public override Dictionary<string, LocaleDetails>? Locales { get; set; } = new()
    {
        { "en", 
            new LocaleDetails
            {
                Name = "",
                ShortName = "",
                Description = ""
            }
        }
    };

}