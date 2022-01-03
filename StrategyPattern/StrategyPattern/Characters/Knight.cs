using Microsoft.Extensions.Logging;
using StrategyPattern.Weapons;

namespace StrategyPattern.Characters
{
    public class Knight : Character
    {
        public Knight(ILogger<Character> logger) : base(logger, new Sword())
        { }
    }
}
