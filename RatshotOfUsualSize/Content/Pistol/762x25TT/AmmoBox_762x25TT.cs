using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public record AmmoBox_762x25TT : NewItemFromCloneDetails
{
    public override MongoId? ItemTplToClone { get; set; } = ItemTpl.AMMOBOX_762X25TT_FMJ43_25RND;
    public override TemplateItemProperties OverrideProperties { get; set; } = new()
    {
        Prefab = new Prefab
        {
            Path = "pistol/ammobox_762x25tt_ratshot.bundle"
        },
        Name = "ammo_box_762x25tt_xx_rat",
        StackMaxRandom = 10,
        StackMaxSize = 1,
        StackMinRandom = 10,
        StackObjectsCount = 1,
        StackSlots = 
        [
            new StackSlot
            {
                Id = "",
                Name = "cartridges",
                Parent = ModItemTpl.AMMOBOX_762X25TT.ToString(),
                MaxCount = 10,
                Properties = new StackSlotProperties
                {
                    Filters = 
                    [
                        new SlotFilter
                        {
                            Filter = 
                            [
                                ModItemTpl.AMMO_762X25TT
                            ]
                        }
                    ]
                },
                Prototype = "5748538b2459770af276a261"
            }
        ]
    };
    public override string ParentId { get; set; } = ParentID.AMMOBOX.ToString();
    public override string NewId { get; set; } = ModItemTpl.AMMOBOX_762X25TT.ToString();
    public override double? FleaPriceRoubles { get; set; }
    public override double? HandbookPriceRoubles { get; set; }
    public override string HandbookParentId { get; set; } = ParentID.AMMOBOX_HANDBOOK.ToString();
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