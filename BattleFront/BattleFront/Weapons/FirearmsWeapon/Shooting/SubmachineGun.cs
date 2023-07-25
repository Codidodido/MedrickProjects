using BattleFront.Interfaces;

namespace BattleFront
{
    public class SubmachineGun : Shooting , IWeapon
    {
        public string Name => "Submachine Gun";
    }
}