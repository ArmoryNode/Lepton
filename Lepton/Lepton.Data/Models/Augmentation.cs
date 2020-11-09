using System;

namespace Lepton.Data.Models
{
    public class Augmentation
    {
        public string Name { get; set; } = string.Empty;
        public int AugmentationLevel { get; set; } = default;
        public int BloodToxicityLevel { get; set; } = default;
    }
}
