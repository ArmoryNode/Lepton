using Lepton.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lepton.Web.ViewModels
{
    public abstract class CharacterBase : ICharacter
    {
        #region Entity Properties

        public string PartitionKey { get; set; }
        public string RowKey { get; set; }

        #endregion

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

        public Vehicle Vehicle { get; set; } = new Vehicle();
        public Mecha MechaSuit { get; set; } = new Mecha();

        public IList<Weapon> Weapons { get; set; } = new List<Weapon>();

        public Armor ArmorSlotOne { get; set; } = new Armor();

        public Armor ArmorSlotTwo { get; set; } = new Armor();

        public IList<Augmentation> Augmentations { get; set; } = new List<Augmentation>();

        public IList<IGearItem> Gear { get; set; } = new List<IGearItem>();

        #endregion

        #region Details
        public string Vice { get; set; } = string.Empty;

        public string Armor { get; set; } = string.Empty;

        public IList<Career> Careers { get; set; } = new List<Career>();

        public Proficiencies Proficiencies { get; set; } = new Proficiencies();

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

        public IList<string> AdditionalFeaturesAndTraits { get; set; } = new List<string>();

        #endregion
    }
}
