using System;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public enum DamageType
    {
        [Display(Name = "")]
        None,
        Ballistic,
        Bludgeoning,
        Electric,
        Fire,
        Grenade,
        Piercing,
        Psychic,
        Slashing
    }
}
