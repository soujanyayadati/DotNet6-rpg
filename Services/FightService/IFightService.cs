using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet6_rpg.Dtos.Fight;

namespace DotNet6_rpg.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultsDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultsDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);

    }
}