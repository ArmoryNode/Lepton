using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lepton.Data.Constants
{
    public static class Configuration
    {
        public static readonly JsonSerializerSettings JsonOptions = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };
    }
}
