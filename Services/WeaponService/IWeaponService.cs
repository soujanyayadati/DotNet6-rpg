using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet6_rpg.Dtos.Character;
using DotNet6_rpg.Dtos.Weapon;

namespace DotNet6_rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}