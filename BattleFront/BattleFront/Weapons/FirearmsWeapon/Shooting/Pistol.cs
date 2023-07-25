using System.Net.Mail;
using BattleFront.Equipment;
using BattleFront.Interfaces;
using Attachment = BattleFront.Equipment.Attachment;

namespace BattleFront
{
    public class Pistol : Shooting , IWeapon
    {
        public string Name => "Pistol";
    }
}