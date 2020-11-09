using System;

namespace Lepton.Data.Models
{
    public class Vehicle : VehicleBase
    {
        public VehicleType Type { get; set; } = default;

        public static Vehicle Empty => new Vehicle();
    }
}
