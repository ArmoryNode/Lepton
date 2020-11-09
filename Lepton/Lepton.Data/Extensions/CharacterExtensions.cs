using Lepton.Data.Models;
using System;

namespace Lepton.Data.Extensions
{
    public static class CharacterExtensions
    {
        public static T ToModel<T>(this ICharacter character) where T : ICharacter, new()
        {
            return new T
            {
                PartitionKey = character.PartitionKey,
                RowKey = character.RowKey,

                Name = character.Name,
                Class = character.Class,
                Level = character.Level,
                Origin = character.Origin,
                Experience = character.Experience,
                Age = character.Age,
                PlayerName = character.PlayerName,
                StreetInfluence = character.StreetInfluence,
                CorporateInfluence = character.CorporateInfluence,

                Strength = character.Strength,
                Dexterity = character.Dexterity,
                Constitution = character.Constitution,
                Intelligence = character.Intelligence,
                Technology = character.Technology,
                People = character.People,

                FortitudeProficient = character.FortitudeProficient,
                ReflexProficient = character.ReflexProficient,
                MindProficient = character.MindProficient,

                AcrobaticsProficient = character.AcrobaticsProficient,
                AthleticsProficient = character.AthleticsProficient,
                BureaucracyProficient = character.BureaucracyProficient,
                ComputingProficient = character.ComputingProficient,
                DeceptionProficient = character.DeceptionProficient,
                EngineeringProficient = character.EngineeringProficient,
                GamblingProficient = character.GamblingProficient,
                HackingProficient = character.HackingProficient,
                HistoryProficient = character.HistoryProficient,
                IntimidationProficient = character.IntimidationProficient,
                InvestigationProficient = character.InvestigationProficient,
                MechanicsProficient = character.MechanicsProficient,
                MedicineProficient = character.MedicineProficient,
                NavigationProficient = character.NavigationProficient,
                PerceptionProficient = character.PerceptionProficient,
                PerformanceProficient = character.PerformanceProficient,
                PersuasionProficient = character.PersuasionProficient,
                PresenceProficient = character.PresenceProficient,
                ReligionProficient = character.ReligionProficient,
                RoboticsProficient = character.RoboticsProficient,
                SenseMotiveProficient = character.SenseMotiveProficient,
                SleightOfHandProficient = character.SleightOfHandProficient,
                StealthProficient = character.StealthProficient,
                StreetwiseProficient = character.StreetwiseProficient,
                TrackingProficient = character.TrackingProficient,
                VehAircraftProficient = character.VehAircraftProficient,
                VehLandProficient = character.VehLandProficient,

                HitPointsMax = character.HitPointsMax,
                HitPoints = character.HitPoints,

                Successes = character.Successes,
                Failures = character.Failures,

                Vehicle = character.Vehicle,
                MechaSuit = character.MechaSuit,
                Weapons = character.Weapons,
                ArmorSlotOne = character.ArmorSlotOne,
                ArmorSlotTwo = character.ArmorSlotTwo,
                Augmentations = character.Augmentations,
                Gear = character.Gear,

                Vice = character.Vice,
                Armor = character.Armor,
                Careers = character.Careers,
                Proficiencies = character.Proficiencies,

                Height = character.Height,
                Eyes = character.Eyes,
                Skin = character.Skin,
                Hair = character.Hair,
                Weight = character.Weight,
                Culture = character.Culture,

                Wolongs = character.Wolongs,
                CharacterNotes = character.CharacterNotes,
                AdditionalFeaturesAndTraits = character.AdditionalFeaturesAndTraits
            };
        }
    }
}
