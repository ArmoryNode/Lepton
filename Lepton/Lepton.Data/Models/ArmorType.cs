using System;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public enum ArmorType
    {
        [Display(Name = "Padded Jumpsuit")]
        PaddedJumpsuit,
        [Display(Name = "Tough Leather Jacket")]
        ToughLeatherJacket,
        [Display(Name = "Za Korp Kevlar Jacket")]
        ZaKorpKevlarJacket,
        [Display(Name = "Kevlar Jacket")]
        KevlarJacket,
        [Display(Name = "Concealable Ballistic Vest")]
        ConcealableBallisticVest,
        [Display(Name = "Kevlar Bodysuit")]
        KevlarBodysuit,
        [Display(Name = "Heavy Concealable Vest")]
        HeavyConcealableVest,
        [Display(Name = "Standard Ballistic Vest")]
        StandardBallisticVest,
        [Display(Name = "Light-Duty Vest")]
        LightDutyVest,
        [Display(Name = "Tactical Vest")]
        TacticalVest,
        [Display(Name = "TCE Body Armor")]
        TCEBodyArmor,
        [Display(Name = "ZA Korp Armor")]
        ZAKorpArmor,
        [Display(Name = "Military Police Armor")]
        MilitaryPoliceArmor,
        [Display(Name = "Battle Armor")]
        BattleArmor,
        [Display(Name = "Light Helmet")]
        LightHelmet,
        Helmet
    }
}
