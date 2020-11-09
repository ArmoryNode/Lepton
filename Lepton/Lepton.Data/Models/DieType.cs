using System;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public enum DieType
    {
        [Display(Name = "")]
        None,
        d3,
        d4,
        d6,
        d8,
        d10,
        d12
    }
}
