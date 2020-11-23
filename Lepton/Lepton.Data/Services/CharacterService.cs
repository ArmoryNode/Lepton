using Lepton.Data.Models;
using Lepton.Data.Storage;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lepton.Data.Services
{
    public class CharacterService
    {
        private readonly IRepository<Character> _characterRepository;

        public CharacterService(IRepository<Character> characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<IEnumerable<Character>> GetAllCharacters(CancellationToken cancellationToken)
        {
            return await _characterRepository.List(cancellationToken);
        }

        public async Task<Character> GetCharacter(string characterId, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(characterId))
                return null;

            return await _characterRepository.Get(characterId, cancellationToken);
        }

        public async Task<bool> UpsertCharacter(Character character, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(character.PartitionKey) || string.IsNullOrWhiteSpace(character.RowKey))
                return false;

            return await _characterRepository.Upsert(character, cancellationToken);
        }

        public async Task<bool> DeleteCharacter(Character character, CancellationToken cancellationToken)
        {
            if (character is null)
                return false;

            return await _characterRepository.Delete(character, cancellationToken);
        }
    }
}
