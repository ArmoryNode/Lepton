using System;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public enum MechaType
    {
        [Display(Name = "Light Mecha")]
        Light,
        [Display(Name = "Medium Mecha")]
        Medium,
        [Display(Name = "Heavy Mecha")]
        Heavy
    }
}
