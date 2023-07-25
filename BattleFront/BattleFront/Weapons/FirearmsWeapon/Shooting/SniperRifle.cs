using BattleFront.Interfaces;

namespace BattleFront
{
    public class SniperRifle : Shooting , IWeapon
    {
        public string Name => "Sniper Rifle";
    }
}