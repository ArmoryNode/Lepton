using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lepton.Data.Models
{
    public interface ICharacter
    {
        #region Entity Properties

        string PartitionKey { get; set; }
        string RowKey { get; set; }

        #endregion

        #region Character Info

        public string Name { get; set; }
        public Class Class { get; set; }
        public int Level { get; set; }
        public Origin Origin { get; set; }
        public int Experience { get; set; }
        public int Age { get; set; }
        public string PlayerName { get; set; }
        public int StreetInfluence { get; set; }
        public int CorporateInfluence { get; set; }

        #endregion

        #region Abilities

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Technology { get; set; }
        public int People { get; set; }

        #endregion

        #region Saving Throws

        public bool FortitudeProficient { get; set; }
        public bool ReflexProficient { get; set; }
        public bool MindProficient { get; set; }

        #endregion

        #region Skills

        public bool AcrobaticsProficient { get; set; }
        public bool AthleticsProficient { get; set; }
        public bool BureaucracyProficient { get; set; }
        public bool ComputingProficient { get; set; }
        public bool DeceptionProficient { get; set; }
        public bool EngineeringProficient { get; set; }
        public bool GamblingProficient { get; set; }
        public bool HackingProficient { get; set; }
        public bool HistoryProficient { get; set; }
        public bool IntimidationProficient { get; set; }
        public bool InvestigationProficient { get; set; }
        public bool MechanicsProficient { get; set; }
        public bool MedicineProficient { get; set; }
        public bool NavigationProficient { get; set; }
        public bool PerceptionProficient { get; set; }
        public bool PerformanceProficient { get; set; }
        public bool PersuasionProficient { get; set; }
        public bool PresenceProficient { get; set; }
        public bool ReligionProficient { get; set; }
        public bool RoboticsProficient { get; set; }
        public bool SenseMotiveProficient { get; set; }
        public bool SleightOfHandProficient { get; set; }
        public bool StealthProficient { get; set; }
        public bool StreetwiseProficient { get; set; }
        public bool TrackingProficient { get; set; }
        public bool VehAircraftProficient { get; set; }
        public bool VehLandProficient { get; set; }

        #endregion

        #region Health

        public int HitPointsMax { get; set; }

        public int HitPoints { get; set; }

        #endregion

        #region Death Saves

        public int Successes { get; set; }
        public int Failures { get; set; }

        #endregion

        #region Equipment and Augmentations

        public Vehicle Vehicle { get; set; }
        public Mecha MechaSuit { get; set; }

        public IList<Weapon> Weapons { get; set; }

        public Armor ArmorSlotOne { get; set; }

        public Armor ArmorSlotTwo { get; set; }

        public IList<Augmentation> Augmentations { get; set; }

        public IList<IGearItem> Gear { get; set; }

        #endregion

        #region Details
        public string Vice { get; set; }

        public string Armor { get; set; }

        public IList<Career> Careers { get; set; }

        public Proficiencies Proficiencies { get; set; }

        #endregion

        #region Appearance

        public string Height { get; set; }
        public string Eyes { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        public string Weight { get; set; }
        public string Culture { get; set; }

        #endregion

        #region Misc

        public int Wolongs { get; set; }

        public string CharacterNotes { get; set; }

        public IList<string> AdditionalFeaturesAndTraits { get; set; }

        #endregion
    }
}
