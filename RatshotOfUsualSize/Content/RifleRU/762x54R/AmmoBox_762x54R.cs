using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public record AmmoBox_762x54R : NewItemFromCloneDetails
{
    public override MongoId? ItemTplToClone { get; set; } = ItemTpl.AMMOBOX_762X54R_FMJ_20RND;
    public override TemplateItemProperties OverrideProperties { get; set; } = new()
    {
        Prefab = new Prefab
        {
            Path = "rifle_ru/ammobox_762x54r_ratshot.bundle"
        },
        Name = "ammo_box_762x54r_xx_rat",
        StackMaxRandom = 10,
        StackMaxSize = 1,
        StackMinRandom = 10,
        StackObjectsCount = 1,
        StackSlots = 
        [
            new StackSlot
            {
                Id = "6941a4f0787395b8cc0ab174",
                Name = "cartridges",
                Parent = ModItemTpl.AMMOBOX_762X54R.ToString(),
                MaxCount = 10,
                Properties = new StackSlotProperties
                {
                    Filters = 
                    [
                        new SlotFilter
                        {
                            Filter = 
                            [
                                ModItemTpl.AMMO_762X54R
                            ]
                        }
                    ]
                },
                Prototype = "5748538b2459770af276a261"
            }
        ]
    };
    public override string ParentId { get; set; } = ParentID.AMMOBOX.ToString();
    public override string NewId { get; set; } = ModItemTpl.AMMOBOX_762X54R.ToString();
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