using System;
using System.Collections.Generic;
using System.Text;

namespace Lepton.Data.Infrastructure
{
    public class StorageSettings
    {
        public string ConnectionString { get; set; }

        public static StorageSettings DefaultSettings => new StorageSettings { ConnectionString = "UseDevelopmentStorage=true" };
    }
}
