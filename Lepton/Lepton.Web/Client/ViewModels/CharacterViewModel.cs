using Lepton.Data.Models;
using System;

using static Lepton.Data.Constants.Lookups;

namespace Lepton.Web.ViewModels
{
    public class CharacterViewModel : CharacterBase
    {
        #region Misc

        public int ProficiencyBonus => GetProficiencyBonus(Level);

        public int PassivePerception {
            get {
                if (PerceptionProficient)
                    return 10 + PerceptionModifier;
                else
                    return 10 + IntelligenceModifier;
            }
        }

        public double EncumberedLimit => Strength * 5;

        public double HeavilyEncumberedLimit => Strength * 10;

        public double MaximumCarryCapacity => Strength * 15;

        public double TotalCarryWeight {
            get {
                double weight = 0.0f;
                if (ArmorSlotOne != null)
                    weight += ArmorSlotOne.Weight;
                if (ArmorSlotTwo != null)
                    weight += ArmorSlotTwo.Weight;

                foreach (var item in Gear)
                {
                    weight += item?.Weight ?? 0;
                }

                return weight;
            }
        }

        #endregion

        #region Abilities

        public int StrengthModifier => GetAbilityModifier(Strength);
        public int DexterityModifier => GetAbilityModifier(Dexterity);
        public int ConstitutionModifier => GetAbilityModifier(Constitution);
        public int IntelligenceModifier => GetAbilityModifier(Intelligence);
        public int TehcnologyModifier => GetAbilityModifier(Technology);
        public int PeopleModifier => GetAbilityModifier(People);

        public int StrengthBonus {
            get {
                return Origin switch
                {
                    Origin.BadBruiser => Strength + 2,
                    Origin.BadScavenger => Strength + 2,
                    Origin.SynthVisser => Strength + 1,
                    _ => default
                };
            }
        }

        public int DexterityBonus {
            get {
                return Origin switch
                {
                    Origin.BadBruiser => Dexterity + 2,
                    Origin.GutterPunk => Dexterity + 2,
                    Origin.SynthHouston => Dexterity + 1,
                    Origin.Wormer => Dexterity + 1,
                    _ => default
                };
            }
        }

        public int ConstitutionBonus {
            get {
                return Origin switch
                {
                    Origin.GutterPunk => Constitution + 1,
                    Origin.Wormer => Constitution + 2,
                    _ => default
                };
            }
        }

        public int IntelligenceBonus {
            get {
                return Origin switch
                {
                    Origin.KorpHighFlyer => Intelligence + 2,
                    Origin.KorpSleeker => Intelligence + 2,
                    _ => default
                };
            }
        }

        public int TechnologyBonus {
            get {
                return Origin switch
                {
                    Origin.BadScavenger => Technology + 2,
                    Origin.GutterPunk => Technology + 2,
                    Origin.KorpHighFlyer => Technology + 1,
                    Origin.KorpSleeker => Technology + 1,
                    _ => default
                };
            }
        }

        public int PeopleBonus {
            get {
                return Origin switch
                {
                    Origin.Joe => People + 2,
                    Origin.SynthShenzen => People + 1,
                    _ => default
                };
            }
        }

        #endregion

        #region Saving Throws

        public int Fortitude => FortitudeProficient ? Constitution + ProficiencyBonus : Constitution;
        public int Reflex => ReflexProficient ? Dexterity + ProficiencyBonus : Dexterity;
        public int Mind => MindProficient ? Intelligence + ProficiencyBonus : Intelligence;

        #endregion

        #region Skills

        public int AcrobaticsModifier => AcrobaticsProficient ? Dexterity + ProficiencyBonus : Dexterity;
        public int AthleticsModifier => AthleticsProficient ? Strength + ProficiencyBonus : Strength;
        public int BureaucracyModifier => BureaucracyProficient ? People + ProficiencyBonus : People;
        public int ComputingModifier => ComputingProficient ? Technology + ProficiencyBonus : Technology;
        public int DeceptionModifier => DeceptionProficient ? People + ProficiencyBonus : People;
        public int EngineeringModifier => EngineeringProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int GamblingModifier => GamblingProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int HackingModifier => HackingProficient ? Technology + ProficiencyBonus : Technology;
        public int HistoryModifier => HistoryProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int IntimidationModifier => IntimidationProficient ? Strength + ProficiencyBonus : Strength;
        public int InvestigationModifier => InvestigationProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int MechanicsModifier => MechanicsProficient ? Technology + ProficiencyBonus : Technology;
        public int MedicineModifier => MedicineProficient ? Technology + ProficiencyBonus : Technology;
        public int NavigationModifier => NavigationProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int PerceptionModifier => PerceptionProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int PerformanceModifier => PerformanceProficient ? People + ProficiencyBonus : People;
        public int PersuasionModifier => PersuasionProficient ? People + ProficiencyBonus : People;
        public int PresenceModifier => PresenceProficient ? People + ProficiencyBonus : People;
        public int ReligionModifier => ReligionProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int RoboticsModifier => RoboticsProficient ? Technology + ProficiencyBonus : Technology;
        public int SenseMotiveModifier => SenseMotiveProficient ? People + ProficiencyBonus : People;
        public int SleightOfHandModifier => SleightOfHandProficient ? Dexterity + ProficiencyBonus : Dexterity;
        public int StealthModifier => StealthProficient ? Dexterity + ProficiencyBonus : Dexterity;
        public int StreetwiseModifier => StreetwiseProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int TrackingModifier => TrackingProficient ? Intelligence + ProficiencyBonus : Intelligence;
        public int VehAircraftModifier => VehAircraftProficient ? Technology + ProficiencyBonus : Technology;
        public int VehLandModifier => VehLandProficient ? Dexterity + ProficiencyBonus : Dexterity;

        #endregion

        #region Combat

        public int ArmorClass {
            get {
                int armorClass = GetNaturalAC(Origin);

                if (ArmorSlotOne?.Equipped ?? false)
                    armorClass += ArmorSlotOne.ArmorClass;
                if (ArmorSlotTwo?.Equipped ?? false)
                    armorClass += ArmorSlotTwo.ArmorClass;

                return armorClass;
            }
        }

        public double DamageReduction {
            get {
                double damageReduction = 0.0f;

                if (ArmorSlotOne?.Equipped ?? false)
                    damageReduction += ArmorSlotOne.DamageResistance;
                if (ArmorSlotTwo?.Equipped ?? false)
                    damageReduction += ArmorSlotTwo.DamageResistance;

                return damageReduction;
            }
        }

        public int Initiative => DexterityModifier;

        public int Speed => CharacterSpeedLookup[Origin];

        public Damage HitDice => GetHitDice(Class, Constitution, Level);

        #endregion
    }
}
