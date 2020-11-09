using System;

namespace Lepton.Data.Models
{
    public class Mecha : VehicleBase
    {
        public MechaType Type { get; set; } = default;

        public static Mecha Empty => new Mecha();
    }
}
