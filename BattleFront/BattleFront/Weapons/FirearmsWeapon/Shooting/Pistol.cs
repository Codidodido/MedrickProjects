using System.Net.Mail;
using BattleFront.Equipment;
using Attachment = BattleFront.Equipment.Attachment;

namespace BattleFront
{
    public class Pistol : Shooting
    {
        public Pistol()
        {
            Equipment = new Attachment[0];
        }
    }
}