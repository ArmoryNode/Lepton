using Lepton.Extensions;
using System;

namespace Lepton.Data.Models
{
    public struct Damage
    {
        public int Amount { get; set; }
        public DieType Die { get; set; }
        public DamageType Type { get; set; }
        public int? Modifer { get; set; }

        public override string ToString()
        {
            if (Die == DieType.None || Amount == default)
                return string.Empty;
            return $"{Amount}{Die.GetDisplayName()} {Type}";
        }
    }
}
