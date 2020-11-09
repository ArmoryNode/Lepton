using System;

namespace Lepton.Data.Models
{
    public class GearItem : IGearItem
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = default;
        public double Weight { get; set; } = default;
        public int Quantity { get; set; } = default;
        public bool Equipped { get; set; } = default;
        public virtual GearType Type { get; set; } = default;
    }
}
