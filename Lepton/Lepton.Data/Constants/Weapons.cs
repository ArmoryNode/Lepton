using Lepton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lepton.Data.Constants
{
    // prefab weapons
    public static class Weapons
    {
        public static readonly Weapon HandToHand = new Weapon
        {
            Name = "Hand-To-Hand",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Type = DamageType.Bludgeoning },
            Weight = 0,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = null,
            Properties = "Light",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon HandToHandBruiser = new Weapon
        {
            Name = "Hand-To-Hand (Bruiser)",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Modifer = -2, Type = DamageType.Bludgeoning },
            Weight = 0,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = null,
            Properties = "Light",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon Baton = new Weapon
        {
            Name = "Baton",
            Damage = new Damage { Amount = 1, Die = DieType.d4, Type = DamageType.Bludgeoning },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = null,
            Properties = "Light",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon Fireaxe = new Weapon
        {
            Name = "Fireaxe",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Type = DamageType.Fire },
            Weight = 3,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = null,
            Properties = "Light, Thrown",
            Range = "20/60",
            Ammo = "None"
        };

        public static readonly Weapon Hammer = new Weapon
        {
            Name = "Hammer",
            Damage = new Damage { Amount = 1, Die = DieType.d4, Type = DamageType.Bludgeoning },
            Weight = 1,
            Bonus = 4,
            Special = "7",
            Properties = "Finesse, Light, Thrown",
            Range = "20/60",
            Ammo = "None"
        };

        public static readonly Weapon Knife = new Weapon
        {
            Name = "Knife",
            Damage = new Damage { Amount = 1, Die = DieType.d4, Type = DamageType.Piercing },
            Weight = 1,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = "7",
            Properties = "Finesse, Light, Thrown",
            Range = "20/60",
            Ammo = "None"
        };

        public static readonly Weapon ManoedgedKatana = new Weapon
        {
            Name = "Manoedged Katana",
            Damage = new Damage { Amount = 1, Die = DieType.d8, Type = DamageType.Slashing },
            Weight = 1,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = "7",
            Properties = "Finesse, Irnores Resistance",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon PhaseShiftKnife = new Weapon
        {
            Name = "Phase Shift Knife",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Type = DamageType.Slashing },
            Weight = 3,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = "7",
            Properties = "Finesse, Light",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon PhaseShiftSword = new Weapon
        {
            Name = "Phase Shift Sword",
            Damage = new Damage { Amount = 1, Die = DieType.d8, Type = DamageType.Slashing },
            Weight = 4,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = null,
            Properties = "Versatile (1d10)",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon CobraRetractableBaton = new Weapon
        {
            Name = "Cobra Retractable Baton",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Type = DamageType.Bludgeoning },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = null,
            Properties = "Light",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon StunBaton = new Weapon
        {
            Name = "Stun Baton",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Type = DamageType.Electric },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = null,
            Properties = "Light",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon VibroKnife = new Weapon
        {
            Name = "Vibro Knife",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Type = DamageType.Piercing },
            Weight = 1,
            Bonus = 4,
            Category = WeaponCategory.Melee,
            Special = "7",
            Properties = "Finesse, Light",
            Range = "5",
            Ammo = "None"
        };

        public static readonly Weapon TwentyFirstCenturyPistol = new Weapon
        {
            Name = "21st Century Pistol",
            Damage = new Damage { Amount = 2, Die = DieType.d4, Type = DamageType.Ballistic },
            Weight = 3,
            Bonus = 4,
            Category = WeaponCategory.Pistol,
            Special = null,
            Properties = "17 Shots, Light",
            Range = "40/100",
            Ammo = "9mm"
        };

        public static readonly Weapon HeavyPistol = new Weapon
        {
            Name = "Heavy Pistol",
            Damage = new Damage { Amount = 2, Die = DieType.d6, Type = DamageType.Ballistic },
            Weight = 4,
            Bonus = 0,
            Category = WeaponCategory.Pistol,
            Special = null,
            Properties = "15 Shots",
            Range = "50/150",
            Ammo = "10mm"
        };

        public static readonly Weapon KHMAHeavyPistol = new Weapon
        {
            Name = "KHMA Heavy Pistol",
            Damage = new Damage { Amount = 2, Die = DieType.d6, Type = DamageType.Ballistic },
            Weight = 4,
            Bonus = 0,
            Category = WeaponCategory.Pistol,
            Special = null,
            Properties = "15 Shots",
            Range = "60/180",
            Ammo = "10mm"
        };

        public static readonly Weapon Revolver = new Weapon
        {
            Name = "Revolver",
            Damage = new Damage { Amount = 2, Die = DieType.d8, Type = DamageType.Ballistic },
            Weight = 3,
            Bonus = 0,
            Category = WeaponCategory.Pistol,
            Special = null,
            Properties = "6 Shots, Light",
            Range = "40/120",
            Ammo = "10mm"
        };

        public static readonly Weapon BlackMarketSMG = new Weapon
        {
            Name = "Black Market SMG",
            Damage = new Damage { Amount = 2, Die = DieType.d4, Type = DamageType.Ballistic },
            Weight = 3,
            Bonus = 0,
            Category = WeaponCategory.SMG,
            Special = "Blackmarket",
            Properties = "20 Shots, Spray, Light",
            Range = "30/90",
            Ammo = "10mm"
        };

        public static readonly Weapon KasaiCorporationSMG = new Weapon
        {
            Name = "Kasai Corporation SMG",
            Damage = new Damage { Amount = 3, Die = DieType.d4, Type = DamageType.Ballistic },
            Weight = 3,
            Bonus = 0,
            Category = WeaponCategory.SMG,
            Special = null,
            Properties = "40 Shots, Spray, Light",
            Range = "40/120",
            Ammo = "10mm"
        };

        public static readonly Weapon DetroitCorporationSMG = new Weapon
        {
            Name = "Detroit Corporation SMG",
            Damage = new Damage { Amount = 4, Die = DieType.d4, Type = DamageType.Ballistic },
            Weight = 3,
            Bonus = 0,
            Category = WeaponCategory.SMG,
            Special = null,
            Properties = "40 Shots, Spray",
            Range = "40/120",
            Ammo = "10mm"
        };

        public static readonly Weapon SawedOffShotgun = new Weapon
        {
            Name = "Sawed-Off Shotgun",
            Damage = new Damage { Amount = 2, Die = DieType.d8, Type = DamageType.Ballistic },
            Weight = 5,
            Bonus = 0,
            Category = WeaponCategory.Shotgun,
            Special = "Blackmarket",
            Properties = "2 Shots (2 Handed)",
            Range = "20/40",
            Ammo = "Shells"
        };

        public static readonly Weapon StreetShotgun = new Weapon
        {
            Name = "Street Shotgun",
            Damage = new Damage { Amount = 2, Die = DieType.d8, Type = DamageType.Ballistic },
            Weight = 7,
            Bonus = 0,
            Category = WeaponCategory.Shotgun,
            Special = null,
            Properties = "2 Shots (2 Handed)",
            Range = "20/50",
            Ammo = "Shells"
        };

        public static readonly Weapon StandardAssaultRifle = new Weapon
        {
            Name = "Standard Assault Rifle",
            Damage = new Damage { Amount = 2, Die = DieType.d8, Type = DamageType.Ballistic },
            Weight = 8,
            Bonus = 0,
            Category = WeaponCategory.Assault,
            Special = null,
            Properties = "30 Shots (2 Handed), Spray",
            Range = "60/180",
            Ammo = "5.56mm"
        };

        public static readonly Weapon KasaiCorporationRifle = new Weapon
        {
            Name = "Kasai Corporation Rifle",
            Damage = new Damage { Amount = 3, Die = DieType.d8, Type = DamageType.Ballistic },
            Weight = 9,
            Bonus = 0,
            Category = WeaponCategory.Assault,
            Special = null,
            Properties = "30 Shots (2 Handed), Spray",
            Range = "60/180",
            Ammo = "5.56mm"
        };

        public static readonly Weapon SniperRifle = new Weapon
        {
            Name = "Sniper Rifle",
            Damage = new Damage { Amount = 2, Die = DieType.d10, Type = DamageType.Ballistic },
            Weight = 9,
            Bonus = 0,
            Category = WeaponCategory.Sniper,
            Special = null,
            Properties = "5 Shots (2 Handed)",
            Range = "150/600",
            Ammo = ".308"
        };

        public static readonly Weapon AdvancedSniperRifle = new Weapon
        {
            Name = "Advanced Sniper Rifle",
            Damage = new Damage { Amount = 3, Die = DieType.d10, Type = DamageType.Ballistic },
            Weight = 10,
            Bonus = 0,
            Category = WeaponCategory.Sniper,
            Special = null,
            Properties = "5 Shots (2 Handed)",
            Range = "250/650",
            Ammo = ".308"
        };

        public static readonly Weapon RapidFireShotgun = new Weapon
        {
            Name = "Rapid Fire Shotgun",
            Damage = new Damage { Amount = 3, Die = DieType.d8, Type = DamageType.Ballistic },
            Weight = 10,
            Bonus = 0,
            Category = WeaponCategory.Combat,
            Special = null,
            Properties = "4 Shots (2 Handed)",
            Range = "20/40",
            Ammo = "Shells"
        };

        public static readonly Weapon KMHACombatShotgun = new Weapon
        {
            Name = "KMHA Combat Shotgun",
            Damage = new Damage { Amount = 3, Die = DieType.d8, Type = DamageType.Ballistic },
            Weight = 7,
            Bonus = 0,
            Category = WeaponCategory.Combat,
            Special = null,
            Properties = "6 Shots (2 Handed)",
            Range = "20/50",
            Ammo = "Shells"
        };

        public static readonly Weapon Minigun = new Weapon
        {
            Name = "Minigun",
            Damage = new Damage { Amount = 2, Die = DieType.d10, Type = DamageType.Ballistic },
            Weight = 25,
            Bonus = 0,
            Category = WeaponCategory.Heavy,
            Special = null,
            Properties = "30 Shots (2 Handed), Spray",
            Range = "50/100",
            Ammo = "Keg"
        };

        public static readonly Weapon HeavyMinigun = new Weapon
        {
            Name = "Heavy Minigun",
            Damage = new Damage { Amount = 3, Die = DieType.d10, Type = DamageType.Ballistic },
            Weight = 35,
            Bonus = 4,
            Category = WeaponCategory.Heavy,
            Special = null,
            Properties = "30 Shots (2 Handed), Spray",
            Range = "50/100",
            Ammo = "Keg"
        };

        public static readonly Weapon GrenadeLauncher = new Weapon
        {
            Name = "Grenade Launcher",
            Damage = new Damage { Amount = 0, Die = DieType.None, Type = DamageType.Grenade },
            Weight = 15,
            Bonus = 4,
            Category = WeaponCategory.Heavy,
            Special = null,
            Properties = "8 Grenades",
            Range = "80/160",
            Ammo = "Grenades"
        };

        public static readonly Weapon Flamethrower = new Weapon
        {
            Name = "Flamethrower",
            Damage = new Damage { Amount = 4, Die = DieType.d6, Type = DamageType.Fire },
            Weight = 20,
            Bonus = 4,
            Category = WeaponCategory.Heavy,
            Special = null,
            Properties = "10 Uses (2 Handed), Spray",
            Range = "10/30",
            Ammo = "Tank"
        };

        public static readonly Weapon FragGrenadeMk1 = new Weapon
        {
            Name = "Frag Grenade Mk I",
            Damage = new Damage { Amount = 2, Die = DieType.d8, Type = DamageType.Piercing },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Grenade,
            Special = null,
            Properties = "Light, Thrown",
            Range = "60",
            Ammo = "None"
        };

        public static readonly Weapon FragGrenadeMk2 = new Weapon
        {
            Name = "Frag Grenade Mk II",
            Damage = new Damage { Amount = 3, Die = DieType.d8, Type = DamageType.Piercing },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Grenade,
            Special = null,
            Properties = "Light, Thrown",
            Range = "60",
            Ammo = "None"
        };

        public static readonly Weapon SmokeGrenade = new Weapon
        {
            Name = "Smoke Grenade",
            Damage = new Damage { Amount = 0, Die = DieType.None, Type = DamageType.None },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Grenade,
            Special = null,
            Properties = "Light, Thrown",
            Range = "60",
            Ammo = "None"
        };

        public static readonly Weapon Flashbang = new Weapon
        {
            Name = "Flashbang",
            Damage = new Damage { Amount = 1, Die = DieType.d6, Type = DamageType.Psychic },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Grenade,
            Special = null,
            Properties = "Light, Thrown",
            Range = "60",
            Ammo = "None"
        };

        public static readonly Weapon EMPGrenade = new Weapon
        {
            Name = "EMP Grenade",
            Damage = new Damage { Amount = 0, Die = DieType.None, Type = DamageType.None },
            Weight = 2,
            Bonus = 4,
            Category = WeaponCategory.Grenade,
            Special = null,
            Properties = "Light, Thrown",
            Range = "60",
            Ammo = "None"
        };
    }
}
