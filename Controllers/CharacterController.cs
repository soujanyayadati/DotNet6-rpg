using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet6_rpg.Dtos.Character;
using DotNet6_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        // 1. Implement the get method to receive our character

        // private static Character Mage = new Character();

        // [HttpGet]
        // public ActionResult<Character> Get()
        // {
        //     return Ok(Mage);
        // }

        // 2. Implement the get method to receive List of characters

        // private static List<Character> characters = new List<Character>{
        //     new Character(),
        //     new Character {Name = "Saachi", Hitpoints = 20}

        // };

        // [HttpGet]
        // public ActionResult<List<Character>> Get()
        // {
        //     return Ok(characters);
        // }

        // 3. Get character based on index value

        // [HttpGet]
        // public ActionResult<Character> GetSingle()
        // {
        //     return Ok(characters[0]);
        // }


        // private static List<Character> characters = new List<Character>{
        //     new Character(),
        //     new Character {Name = "Saachi", Hitpoints = 20}

        // };

        // private static List<Character> characters = new List<Character>{
        //     new Character(),
        //     new Character { Id = 1, Name = "Saachi", Hitpoints = 20}

        // };

        // 4. Implement the get method to receive List of characters with Route
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
 
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetAllCharacters()
        {
            return Ok(await _characterService.GetAllCharacters());
        }
       

        // 5. This method returns the first character where the idea of the character equals
        // the given ID and here we specified Id in object initialization.Here sending Id via route URL
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetCharcterById(int id)
        {
            return Ok(await _characterService.GetCharcterById(id));
        }
        // 6. Adding new character and sending JSON data via body of the Request

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddNewCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddNewCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

         [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            return Ok(await _characterService.AddCharacterSkill(newCharacterSkill));
        }
    }
}