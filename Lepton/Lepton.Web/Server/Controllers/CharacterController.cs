using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Lepton.Data.Extensions;
using Lepton.Data.Models;
using Lepton.Data.Services;
using Lepton.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lepton.Web.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private CharacterService CharacterService { get; }
        private MockCharacterService MockCharacterService { get; }

        public CharacterController(CharacterService characterService, MockCharacterService mockCharacterService)
        {
            CharacterService = characterService;
            MockCharacterService = mockCharacterService;
        }

        [HttpGet("Character")]
        [Route("{characterId?}")]
        public async Task<object> Character([FromRoute]string characterId, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(characterId))
            {
                var characters = await MockCharacterService.GetAllCharacters();
                return characters.Select(c => c.ToModel<CharacterViewModel>());
            }
            else
            {
                var character = await MockCharacterService.GetCharacter(characterId);
                return character.ToModel<CharacterViewModel>();
            }
        }

        [HttpGet("CharacterIndex")]
        public async Task<IEnumerable<CharacterIndex>> CharacterIndex()
        {
            var characterIndex = await MockCharacterService.IndexAllCharacters();
            return characterIndex;
        }

        [HttpDelete("Character")]
        public async Task<bool> DeleteCharacter(CharacterViewModel character, CancellationToken cancellationToken)
        {
            if (character is null)
                return false;

            try
            {
                await CharacterService.DeleteCharacter(character.ToModel<Character>(), cancellationToken);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("Character")]
        public async Task<bool> UpsertCharacter(CharacterViewModel character, CancellationToken cancellationToken)
        {
            if (character is null)
                return false;

            return await CharacterService.UpsertCharacter(character.ToModel<Character>(), cancellationToken);
        }
    }
}
