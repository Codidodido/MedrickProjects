using BattleFront.ChemicalWeapon;
using BattleFront.ColdWeapons;
using BattleFront.Equipment;
using BattleFront.RocketWeapon;


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
            //Adam Killed
            
            
            // Throw Test
            People Hava = new People
            {
                Health = 100,
                CanWalk = true,
                CanSee = true,
                CanFocus = true,
                Name = "Hava"
            };
            TearGas tearGas = new TearGas
            {
                Damage = 20,
                FireRate = 1,
                Mobility = 100,
                Range = 60,
                Accuracy = 75,
                Control = 50,
                Ammunition = 1,
                Name = "Tear Gas",
                Radius = 5,
                Type = "Breath",
                BakeTime = 2,

            };
            tearGas.Info();
            tearGas.Throw(Hava);
            RPG rpg = new RPG
            {
                Damage = 80,
                FireRate = 1,
                Mobility = 10,
                Range = 90,
                Accuracy = 90,
                Control = 70,
                Ammunition = 2,
                Name = "RPG7",
                Radius = 2,
                Type = "Nerve"
            };
            rpg.Throw(Hava);
            
            //Hava Killed

            Sword excalibur = new Sword
            {
                Damage = 37,
                FireRate = 1,
                Mobility = 100,
                Range = 1,
                Name = "excalibur"
            };

            People Arthor = new People
            {
                Health = 100,
                CanWalk = true,
                CanSee = true,
                CanFocus = true,
                Name = "Arthor"
            };

            while (Arthor.Health > 0)
            {
                excalibur.Attack(Arthor);
            }
        }
        
        
    }
}