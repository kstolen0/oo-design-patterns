using Microsoft.Extensions.Logging;
using StrategyPattern.Weapons;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        private IWeapon _weapon;

        private ILogger<Character> _logger;
        protected Character(ILogger<Character> logger, IWeapon weapon)
        {
            _logger = logger;
            _weapon = weapon;
        }

        public int Fight()
        {
            _logger.LogInformation("fighting");
            return _weapon.UseWeapon();
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon ?? new Fists();
        }
    }
}
