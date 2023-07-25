using BattleFront.Interfaces;

namespace BattleFront
{
    public class AssaultRifle : Shooting , IWeapon
    {
        public string Name => "Assault Rifle";
    }
}