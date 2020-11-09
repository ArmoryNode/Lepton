using Microsoft.Azure.Cosmos.Table;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public class Character : TableEntity, ICharacter
    {
        public Character()
        {
        }

        public Character(string characterId, string playerId)
        {
            RowKey = characterId;
            PartitionKey = playerId;
        }

        #region Character Info

        public string Name { get; set; } = string.Empty;
        public Class Class { get; set; } = default;
        public int Level { get; set; } = default;
        public Origin Origin { get; set; } = default;
        public int Experience { get; set; } = 0;
        public int Age { get; set; } = default;
        public string PlayerName { get; set; } = string.Empty;
        public int StreetInfluence { get; set; } = default;
        public int CorporateInfluence { get; set; } = default;

        #endregion

        #region Abilities

        public int Strength { get; set; } = default;
        public int Dexterity { get; set; } = default;
        public int Constitution { get; set; } = default;
        public int Intelligence { get; set; } = default;
        public int Technology { get; set; } = default;
        public int People { get; set; } = default;

        #endregion

        #region Saving Throws

        public bool FortitudeProficient { get; set; } = default;
        public bool ReflexProficient { get; set; } = default;
        public bool MindProficient { get; set; } = default;

        #endregion

        #region Skills

        public bool AcrobaticsProficient { get; set; } = default;
        public bool AthleticsProficient { get; set; } = default;
        public bool BureaucracyProficient { get; set; } = default;
        public bool ComputingProficient { get; set; } = default;
        public bool DeceptionProficient { get; set; } = default;
        public bool EngineeringProficient { get; set; } = default;
        public bool GamblingProficient { get; set; } = default;
        public bool HackingProficient { get; set; } = default;
        public bool HistoryProficient { get; set; } = default;
        public bool IntimidationProficient { get; set; } = default;
        public bool InvestigationProficient { get; set; } = default;
        public bool MechanicsProficient { get; set; } = default;
        public bool MedicineProficient { get; set; } = default;
        public bool NavigationProficient { get; set; } = default;
        public bool PerceptionProficient { get; set; } = default;
        public bool PerformanceProficient { get; set; } = default;
        public bool PersuasionProficient { get; set; } = default;
        public bool PresenceProficient { get; set; } = default;
        public bool ReligionProficient { get; set; } = default;
        public bool RoboticsProficient { get; set; } = default;
        public bool SenseMotiveProficient { get; set; } = default;
        public bool SleightOfHandProficient { get; set; } = default;
        public bool StealthProficient { get; set; } = default;
        public bool StreetwiseProficient { get; set; } = default;
        public bool TrackingProficient { get; set; } = default;
        public bool VehAircraftProficient { get; set; } = default;
        public bool VehLandProficient { get; set; } = default;

        #endregion

        #region Health

        public int HitPointsMax { get; set; } = default;
        public int HitPoints { get; set; } = default;

        #endregion

        #region Death Saves

        public int Successes { get; set; } = default;
        public int Failures { get; set; } = default;

        #endregion

        #region Equipment and Augmentations

        public string VehicleRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public Vehicle Vehicle {
            get => JsonConvert.DeserializeObject<Vehicle>(VehicleRaw);
            set => VehicleRaw = JsonConvert.SerializeObject(value);
        }

        public string MechaSuitRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public Mecha MechaSuit {
            get => JsonConvert.DeserializeObject<Mecha>(MechaSuitRaw);
            set => MechaSuitRaw = JsonConvert.SerializeObject(value);
        }

        public string WeaponsRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<Weapon> Weapons {
            get => JsonConvert.DeserializeObject<IList<Weapon>>(WeaponsRaw) ?? new List<Weapon>();
            set => WeaponsRaw = JsonConvert.SerializeObject(value);
        }

        public string ArmorSlotOneRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public Armor ArmorSlotOne {
            get => JsonConvert.DeserializeObject<Armor>(ArmorSlotOneRaw);
            set => ArmorSlotOneRaw = JsonConvert.SerializeObject(value);
        }

        public string ArmorSlotTwoRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public Armor ArmorSlotTwo {
            get => JsonConvert.DeserializeObject<Armor>(ArmorSlotTwoRaw);
            set => ArmorSlotTwoRaw = JsonConvert.SerializeObject(value);
        }

        public string AugmentationsRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<Augmentation> Augmentations {
            get => JsonConvert.DeserializeObject<IList<Augmentation>>(AugmentationsRaw) ?? new List<Augmentation>();
            set => AugmentationsRaw = JsonConvert.SerializeObject(value);
        }

        public string GearRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<IGearItem> Gear {
            get => JsonConvert.DeserializeObject<IList<IGearItem>>(GearRaw) ?? new List<IGearItem>();
            set => GearRaw = JsonConvert.SerializeObject(value);
        }

        #endregion

        #region Details

        public string Vice { get; set; } = string.Empty;
        public string Armor { get; set; } = string.Empty;

        public string CareersRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<Career> Careers {
            get => JsonConvert.DeserializeObject<IList<Career>>(CareersRaw) ?? new List<Career>();
            set => CareersRaw = JsonConvert.SerializeObject(value);
        }

        public string ProficienciesRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public Proficiencies Proficiencies {
            get => JsonConvert.DeserializeObject<Proficiencies>(ProficienciesRaw);
            set => ProficienciesRaw = JsonConvert.SerializeObject(value);
        }

        #endregion

        #region Appearance

        public string Height { get; set; } = string.Empty;
        public string Eyes { get; set; } = string.Empty;
        public string Skin { get; set; } = string.Empty;
        public string Hair { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string Culture { get; set; } = string.Empty;

        #endregion

        #region Misc

        public int Wolongs { get; set; } = default;
        public string CharacterNotes { get; set; } = string.Empty;

        public string AdditionalFeaturesAndTraitsRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<string> AdditionalFeaturesAndTraits {
            get => JsonConvert.DeserializeObject<IList<string>>(AdditionalFeaturesAndTraitsRaw) ?? new List<string>();
            set => AdditionalFeaturesAndTraitsRaw = JsonConvert.SerializeObject(value);
        }

        #endregion
    }
}
