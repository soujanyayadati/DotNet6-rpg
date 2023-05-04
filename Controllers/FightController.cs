using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet6_rpg.Dtos.Fight;
using DotNet6_rpg.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController: ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async  Task<ActionResult<ServiceResponse<AttackResultsDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

         [HttpPost("Skill")]
        public async  Task<ActionResult<ServiceResponse<AttackResultsDto>>> SkillAttack(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }

         [HttpPost]
        public async  Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request)
        {
            return Ok(await _fightService.Fight(request));
        }
    }
}