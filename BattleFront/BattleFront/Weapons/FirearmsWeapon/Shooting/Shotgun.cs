using BattleFront.Interfaces;

namespace BattleFront
{
    public class Shotgun : Shooting , IWeapon
    {
        public string Name => "Shotgun";
    }
}