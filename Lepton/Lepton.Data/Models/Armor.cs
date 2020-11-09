using System;

namespace Lepton.Data.Models
{
    public class Armor : GearItem
    {
        public int ArmorClass { get; set; } = default;
        public double DamageResistance { get; set; } = default;
        public override GearType Type => GearType.Armor;
    }
}
