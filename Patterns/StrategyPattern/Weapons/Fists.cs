namespace StrategyPattern.Weapons
{
    public class Fists : IWeapon
    {
        public string WeaponName => nameof(Fists);

        (int range, int damage) IWeapon.UseWeapon()
        {
            return (range: 1, damage: 10);
        }
    }
}
