namespace StrategyPattern.Weapons
{
    public class Sword : IWeapon
    {
        public string WeaponName => nameof(Sword);

        (int range, int damage) IWeapon.UseWeapon()
        {
            return (range: 2, damage: 30);
        }
    }
}
