using Lepton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lepton.Data.Constants
{
    public static class Testing
    {
        public static Character TestCharacter { get; set; } = new Character
        {
            PartitionKey = Guid.NewGuid().ToString(),
            RowKey = Guid.NewGuid().ToString(),
            Name = "Joe",
            Class = Class.Scoundrel,
            Origin = Origin.Joe,
            Level = 2,
            Vehicle = new Vehicle
            {
                ArmorClass = 2,
                Seats = 1,
                Speed = "60mph",
                Type = VehicleType.Motorbike,
                HitPoints = 20
            }
        };
    }
}
