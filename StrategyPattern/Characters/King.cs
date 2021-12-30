using Microsoft.Extensions.Logging;
using StrategyPattern.Weapons;

namespace StrategyPattern.Characters
{
    public class King : Character
    {
        public King(ILogger<Character> logger) : base(logger, new Fists())
        { }
    }
}
