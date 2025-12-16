using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public record AmmoBox_93x64 : NewItemFromCloneDetails
{
    public override MongoId? ItemTplToClone { get; set; } = CompatRefID.AMMOBOX_BASE_93X64;
    public override TemplateItemProperties OverrideProperties { get; set; }
    public override string ParentId { get; set; }
    public override string NewId { get; set; }
    public override double? FleaPriceRoubles { get; set; } = 69;
    public override double? HandbookPriceRoubles { get; set; } = 69;
    public override string HandbookParentId { get; set; }
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