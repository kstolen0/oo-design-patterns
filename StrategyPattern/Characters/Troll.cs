using Microsoft.Extensions.Logging;
using StrategyPattern.Weapons;

namespace StrategyPattern.Characters
{
    public class Troll : Character
    {
        public Troll(ILogger<Character> logger) : base(logger, new Fists())
        { }
    }
}
