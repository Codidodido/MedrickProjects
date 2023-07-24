using BattleFront.Equipment;


namespace BattleFront
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pistol colt = new Pistol
            {
                Name = "Colt",
                Damage = 10f,
                FireRate = 10f,
                Mobility = 10f,
                Range = 10f,
                Accuracy = 10f,
                Control = 10f,
                Ammunition = 7,
                RP = 0.5f,
                Equipment = new Attachment[]
                {
                    Attachment.Laser,
                    Attachment.Magazine,
                    Attachment.Muzzle
                },

            };

            People Adam = new People
            {
                Health = 100,
                CanWalk = true,
                CanSee = true,
                CanFocus = true,
                Name = "Adam"
            };
            
            colt.Info();
            while (colt.Ammunition>0)
            {
                colt.Shot(Adam);    
            }

            Shotgun Remington = new Shotgun
            {
                Damage = 30,
                FireRate = 2,
                Mobility = 5,
                Range = 5,
                Accuracy = 8,
                Control = 7,
                Ammunition = 2,
                Name = "Remington 870",
                RP = 2f,
                Equipment = new Attachment[]
                {
                    Attachment.Laser,
                    Attachment.Magazine,
                    Attachment.Muzzle,
                    Attachment.Barrel
                }
            };

            while (Remington.Ammunition > 0)
            {
                Remington.Shot(Adam);
            }
            


        }
    }
}