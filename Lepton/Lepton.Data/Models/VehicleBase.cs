using System;
using System.Collections.Generic;
using System.Text;

namespace Lepton.Data.Models
{
    public abstract class VehicleBase
    {
        public string Speed { get; set; } = string.Empty;
        public int ArmorClass { get; set; } = default;
        public int HitPoints { get; set; } = default;
        public int DamageThreshold { get; set; } = default;
        public int Seats { get; set; } = default;
    }
}
