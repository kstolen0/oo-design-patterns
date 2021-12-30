namespace StrategyPattern.Weapons
{
    public interface IWeapon
    {
        public (int range, int damage) UseWeapon();
        public string WeaponName { get; }
    }
}
