using Lepton.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lepton.Data.Services
{
    public struct CharacterIndex
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class MockCharacterService
    {
        private static string GenerateId => Guid.NewGuid().ToString("N").Substring(0, 8);

        private List<Character> Characters { get; } = new List<Character>
        {
            new Character("f6e6a208", Guid.Empty.ToString()) { Name = "Bob" },
            new Character("06c454f8", Guid.Empty.ToString()) { Name = "Joe" },
            new Character("bf0a24af", Guid.Empty.ToString()) { Name = "Tim" },
            new Character("04eab69c", Guid.Empty.ToString()) { Name = "Josiah" },
            new Character("7fa4cf0c", Guid.Empty.ToString()) { Name = "Matthew" },
            new Character("b48a977f", Guid.Empty.ToString()) { Name = "Sarah" },
            new Character("e2e128a7", Guid.Empty.ToString()) { Name = "Kimberly" },
            new Character("043daa40", Guid.Empty.ToString()) { Name = "Samantha" },
            new Character("aaa26458", Guid.Empty.ToString()) { Name = "Carol" },
            new Character("519d4892", Guid.Empty.ToString()) { Name = "Emily" }
        };

        public MockCharacterService()
        {
        }

        public Task<Character> GetCharacter(string characterId)
        {
            if (string.IsNullOrWhiteSpace(characterId))
                return null;

            return Task.FromResult(Characters.SingleOrDefault(c => c.RowKey == characterId));
        }

        public Task<IEnumerable<Character>> GetAllCharacters()
        {
            return Task.FromResult<IEnumerable<Character>>(Characters);
        }

        public Task<IEnumerable<CharacterIndex>> IndexAllCharacters()
        {
            var characterList = Characters.Select(c => new CharacterIndex { Name = c.Name, Id = c.RowKey });
            return Task.FromResult(characterList);
        }
    }
}
