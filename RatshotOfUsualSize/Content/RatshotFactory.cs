using SPTarkov.Server.Core.Models.Spt.Mod;

namespace RatshotOfUsualSize;

public static class RatshotFactory
{
    public static List<NewItemFromCloneDetails> GetRatshotItems()
    {
        return
        [
            new Ammo_9x33R(),
            new AmmoBox_9x33R(),
            
            new Ammo_50AE(),
            new AmmoBox_50AE(),
            
            new Ammo_366TKM(),
            new AmmoBox_366TKM(),
            
            new Ammo_338LM(),
            new AmmoBox_338LM()
        ];
    }
    
    public static List<NewItemFromCloneDetails> GetUnbalancedRatshotItems()
    {
        return
        [
            new Ammo_46x30(),
            new AmmoBox_46x30(),
            
            new Ammo_57x28(),
            new AmmoBox_57x28(),
            
            new Ammo_9x18(),
            new AmmoBox_9x18(),
            
            new Ammo_9x19(),
            new AmmoBox_9x19(),
            
            new Ammo_9x21(),
            new AmmoBox_9x21(),
            
            new Ammo_20x1(),
            new AmmoBox_20x1(),
            
            new Ammo_45ACP(),
            new AmmoBox_45ACP(),
            
            new Ammo_762x25TT(),
            new AmmoBox_762x25TT(),
            
            new Ammo_9x39(),
            new AmmoBox_9x39(),
            
            new Ammo_127x55(),
            new AmmoBox_127x55(),
            
            new Ammo_762x39(),
            new AmmoBox_762x39(),
            
            new Ammo_762x54R(),
            new AmmoBox_762x54R(),
            
            new Ammo_68x51(),
            new AmmoBox_68x51(),
            
            new Ammo_300BLK(),
            new AmmoBox_300BLK(),
            
            new Ammo_556x45(),
            new AmmoBox_556x45(),
            
            new Ammo_762x51(),
            new AmmoBox_762x51()
        ];
    }
}