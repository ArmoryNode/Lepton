using Microsoft.Azure.Cosmos.Table;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Lepton.Data.Models
{
    public class Proficiencies
    {
        public string WeaponsRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<string> Weapons {
            get => JsonConvert.DeserializeObject<IList<string>>(WeaponsRaw);
            set => WeaponsRaw = JsonConvert.SerializeObject(value);
        }

        public string ArmorRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<string> Armor {
            get => JsonConvert.DeserializeObject<IList<string>>(ArmorRaw);
            set => ArmorRaw = JsonConvert.SerializeObject(value);
        }

        public string ToolsRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<string> Tools {
            get => JsonConvert.DeserializeObject<IList<string>>(ToolsRaw);
            set => ToolsRaw = JsonConvert.SerializeObject(value);
        }

        public string LanguagesRaw { get; set; } = string.Empty;
        [IgnoreProperty]
        public IList<string> Languages {
            get => JsonConvert.DeserializeObject<IList<string>>(LanguagesRaw);
            set => LanguagesRaw = JsonConvert.SerializeObject(value);
        }
    }
}
