using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public record AmmoBox_45ACP : NewItemFromCloneDetails
{
    public override MongoId? ItemTplToClone { get; set; } = ItemTpl.AMMOBOX_45ACP_FMJ_50RND;

    public override TemplateItemProperties? OverrideProperties { get; set; } = new()
    {
        Prefab = new Prefab
        {
            Path = "pistol/ammobox_45acp_ratshot.bundle"
        },
        Name = "ammo_box_45acp_xx_rat",
        StackMaxRandom = 10,
        StackMaxSize = 1,
        StackMinRandom = 10,
        StackObjectsCount = 1,
        StackSlots = 
        [
            new StackSlot
            {
                Id = "6941a4b9787395b8cc0ab16b",
                Name = "cartridges",
                Parent = ModItemTpl.AMMOBOX_45ACP.ToString(),
                MaxCount = 10,
                Properties = new StackSlotProperties
                {
                    Filters = 
                    [
                        new SlotFilter
                        {
                            Filter = 
                            [
                                ModItemTpl.AMMO_45ACP
                            ]
                        }
                    ]
                },
                Prototype = "5748538b2459770af276a261"
            }
        ]
    };
    public override string? ParentId { get; set; } = ParentID.AMMOBOX.ToString();
    public override string? NewId { get; set; } = ModItemTpl.AMMOBOX_45ACP.ToString();
    public override double? FleaPriceRoubles { get; set; }
    public override double? HandbookPriceRoubles { get; set; }
    public override string? HandbookParentId { get; set; } = ParentID.AMMOBOX_HANDBOOK.ToString();
    public override Dictionary<string, LocaleDetails>? Locales { get; set; } = new()
    {
        { 
            "en", 
            new LocaleDetails
            {
                Name = ".45 ACP Shotshell ammo pack (10 pcs)",
                ShortName = "Shotshell",
                Description = "A box of .45 ACP Ratshot cartridges, 10 pieces."
            }
        }
    };
}