using Microsoft.Extensions.Logging;
using StrategyPattern.Weapons;
using System;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        private IWeapon _weapon;

        private ILogger<Character> _logger;
        protected double _damageModifier = 1.0;

        protected Character(ILogger<Character> logger, IWeapon weapon)
        {
            _logger = logger;
            _weapon = weapon ?? new Fists();
        }

        public (int range, int damage) Fight()
        {
            _logger.LogInformation("fighting");
            var attack = _weapon.UseWeapon();

            return (attack.range, (int)Math.Floor(attack.damage * _damageModifier));
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon ?? new Fists();
        }

        public string GetCurrentWeapon()
        {
            return _weapon.WeaponName;
        }
    }
}
