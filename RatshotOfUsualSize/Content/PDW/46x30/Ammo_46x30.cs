using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public record Ammo_46x30 : NewItemFromCloneDetails
{
    public override MongoId? ItemTplToClone { get; set; } = ItemTpl.AMMO_46X30_FMJ_SX;

    public override TemplateItemProperties OverrideProperties { get; set; } = new()
    {
        
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