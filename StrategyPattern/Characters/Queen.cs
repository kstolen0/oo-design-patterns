using Microsoft.Extensions.Logging;

namespace StrategyPattern.Characters
{
    public class Queen : Character
    {
        public Queen(ILogger<Character> logger) : base(logger)
        {

        }
    }
}
