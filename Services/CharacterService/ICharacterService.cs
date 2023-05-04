using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet6_rpg.Dtos.Character;

namespace DotNet6_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharcterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddNewCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto UpdatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);


    }
}