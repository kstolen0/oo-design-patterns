namespace StrategyPattern.Weapons
{
    public class BowAndArrow : IWeapon
    {
        public string WeaponName => nameof(BowAndArrow);

        public (int range, int damage) UseWeapon()
        {
            return (8, 2);
        }
    }
}
