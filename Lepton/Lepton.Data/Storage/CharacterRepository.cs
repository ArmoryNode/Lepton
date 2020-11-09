using Lepton.Data.Infrastructure;
using Lepton.Data.Models;
using System;
using System.Linq;

namespace Lepton.Data.Storage
{
    public class CharacterRepository : RepositoryBase<Character>
    {
        public CharacterRepository(StorageSettings settings) : base(settings)
        {
        }
    }
}
