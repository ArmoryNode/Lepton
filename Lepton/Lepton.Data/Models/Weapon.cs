using Microsoft.Azure.Cosmos.Table;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Lepton.Data.Models
{
    public class Weapon
    {
        public string Name { get; set; }

        public string DamageRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public Damage Damage {
            get => JsonConvert.DeserializeObject<Damage>(DamageRaw);
            set => DamageRaw = JsonConvert.SerializeObject(value);
        }

        public string Ammo { get; set; }
        public int Weight { get; set; }
        public int Bonus { get; set; }
        public WeaponCategory Category { get; set; }
        public string Special { get; set; }
        public string Properties { get; set; }
        public string Range { get; set; }
        public string AmmoType { get; set; }
    }
}
