using Microsoft.Extensions.Logging;

namespace StrategyPattern.Characters
{
    public class King : Character
    {
        public King(ILogger<Character> logger) : base(logger)
        { }
    }
}
