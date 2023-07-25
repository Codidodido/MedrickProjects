using BattleFront.Interfaces;

namespace BattleFront
{
    public class LightMachineGun : Shooting , IWeapon
    {
        public string Name => "Light Machine Gun";
    }
}