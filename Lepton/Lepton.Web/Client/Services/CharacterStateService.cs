using Lepton.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lepton.Web.Client.Services
{
    public class CharacterStateService
    {
        public event Action CharacterChanged;

        public CharacterViewModel Character { get; private set; }

        public Task SetAsync(CharacterViewModel character)
        {
            Character = character;

            CharacterChanged?.Invoke();

            return Task.CompletedTask;
        }

        public void Set(CharacterViewModel character)
        {
            CharacterChanged?.Invoke();

            Character = character;
        }
    }
}
