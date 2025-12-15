using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public record Ammo_45ACP : NewItemFromCloneDetails
{
    public override MongoId? ItemTplToClone { get; set; } = ItemTpl.AMMO_45ACP_FMJ;

    public override TemplateItemProperties OverrideProperties { get; set; } = new()
    {
        Prefab = new Prefab
        {
            Path = "pistol/ammo_45acp_ratshot.bundle"
        },
        Name = "ammo_45acp_xx_rat",
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
    public override string? ParentId { get; set; } = ParentID.AMMO.ToString();
    public override string? NewId { get; set; } = ModItemTpl.AMMO_45ACP.ToString();
    public override double? FleaPriceRoubles { get; set; } = 40;
    public override double? HandbookPriceRoubles { get; set; } = 20;
    public override string? HandbookParentId { get; set; } = ParentID.AMMO_HANDBOOK.ToString();
    public override Dictionary<string, LocaleDetails>? Locales { get; set; } = new()
    {
        { "en", 
            new LocaleDetails
            {
                Name = ".45 ACP Shotshell",
                ShortName = "Shotshell",
                Description = "A .45 ACP (11.43x23mm) Shotshell is a cartridge with 10 small pellets designed for elimination of rodents where a full shotgun shell would be considered overkill. In a pinch, it can be used offensively as a deterrent for burglers or enemy combatants wondering why they just got stung by 10 angry lead hornets. Manufactured by ZharArms."
            }
        }
    };
    
}