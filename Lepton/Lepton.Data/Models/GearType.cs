using System;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public enum GearType
    {
        [Display(Name = "")]
        None,
        Armor,
        [Display(Name = "Kits & Tools")]
        KitsAndTools,
        [Display(Name = "Medication & Drugs")]
        MedicationAndDrugs,
        [Display(Name = "Weapons & Ammo")]
        WeaponsAndAmmo
    }
}
