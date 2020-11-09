using Lepton.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Lepton.Data.Constants
{
    public static class Lookups
    {
        public static int GetNaturalAC(Origin origin) =>
            origin switch
            {
                Origin.SynthHouston => 15,
                Origin.SynthShenzen => 15,
                Origin.SynthVisser => 15,
                _ => 0
            };

        public static int GetAbilityModifier(int abilityAmount) =>
            abilityAmount switch
            {
                20 => 5,
                int i when i >= 18 => 4,
                int i when i >= 16 => 3,
                int i when i >= 14 => 2,
                int i when i >= 12 => 1,
                int i when i >= 10 => 0,
                int i when i >= 8 => -1,
                int i when i >= 1 => -2,
                _ => default
            };

        public static int GetProficiencyBonus(int level) =>
            level switch
            {
                int i when i < 5 => 2,
                int i when i < 9 => 3,
                int i when i <= 10 => 4,
                _ => default
            };

        public static Damage GetHitDice(Class characterClass, int constitution, int level)
        {
            var modifier = GetAbilityModifier(constitution);
            return characterClass switch
            {
                Class.Daimyo => new Damage { Amount = level, Die = DieType.d12, Modifer = modifier },
                Class.Doc => new Damage { Amount = level, Die = DieType.d8, Modifer = modifier },
                Class.Enforcer => new Damage { Amount = level, Die = DieType.d10, Modifer = modifier },
                Class.Hacker => new Damage { Amount = level, Die = DieType.d8, Modifer = modifier },
                Class.Investigator => new Damage { Amount = level, Die = DieType.d8, Modifer = modifier },
                Class.Scoundrel => new Damage { Amount = level, Die = DieType.d8, Modifer = modifier },
                _ => default
            };
        }

        public static readonly Dictionary<Origin, int> CharacterSpeedLookup = new Dictionary<Origin, int>
        {
            [Origin.BadBruiser] = 30,
            [Origin.BadScavenger] = 30,
            [Origin.GutterPunk] = 35,
            [Origin.KorpHighFlyer] = 30,
            [Origin.KorpSleeker] = 30,
            [Origin.Joe] = 30,
            [Origin.SynthHouston] = 30,
            [Origin.SynthShenzen] = 30,
            [Origin.SynthVisser] = 30,
            [Origin.Wormer] = 40,
        };
    }
}
