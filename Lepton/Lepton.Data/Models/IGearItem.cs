using System;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public interface IGearItem
    {
        string Name { get; set; }
        decimal Price { get; set; }
        double Weight { get; set; }
        bool Equipped { get; set; }
        int Quantity { get; set; }
        GearType Type { get; set; }
    }
}
