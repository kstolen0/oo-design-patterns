using Microsoft.Extensions.Logging;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        protected ILogger<Character> _logger;
        protected Character(ILogger<Character> logger)
        {
            _logger = logger;
        }

        public int Fight()
        {
            _logger.LogInformation("fighting");
            return 1;
        }
    }
}
