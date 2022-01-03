using Microsoft.Extensions.Logging;
using StrategyPattern.Weapons;

namespace StrategyPattern.Characters
{
    public class Queen : Character
    {
        public Queen(ILogger<Character> logger) : base(logger, new Fists())
        {

        }
    }
}
