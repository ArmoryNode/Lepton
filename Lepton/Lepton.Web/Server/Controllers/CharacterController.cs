using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Lepton.Data.Models;
using Lepton.Data.Services;
using Microsoft.AspNetCore.Mvc;
namespace Lepton.Web.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private CharacterService CharacterService { get; }

        public CharacterController(CharacterService characterService)
        {
            CharacterService = characterService;
        }

        [HttpPost]
        public async Task<Character> Character(Character character, CancellationToken cancellationToken)
        {
            await CharacterService.UpsertCharacter(character, cancellationToken);
            return character;
        }

        [HttpGet]
        public async Task<IEnumerable<Character>> Character(string characterId, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(characterId))
            {
                return await CharacterService.GetAllCharacters(cancellationToken);
            }
            else
            {
                var character = await CharacterService.GetCharacter(characterId, cancellationToken);
                return new Character[] { character };
            }
        }
    }
}
