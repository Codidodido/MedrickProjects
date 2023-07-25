using System;
using BattleFront.BombWeapon;
using BattleFront.ChemicalWeapon;
using BattleFront.ColdWeapons;
using BattleFront.Interfaces;
using BattleFront.RocketWeapon;

namespace BattleFront
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO BATTLEFRONT GAME");
            Console.WriteLine("\nChoose your weapon type: ");
            Console.WriteLine("\t1. Shooting\n\t2. Throwing\n\t3. Cold");
            int Type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose your weapon: ");
            string weapon;
            IWeapon selectedWeapon = null;
            switch (Type)
            {
                case 1:
                    Console.WriteLine("\t1. Assault rifle\n\t2. Light machine gun\n\t3. Pistol\n\t4. Shotgun\n\t5. Sniper rifle\n\t6. Submachine gun");
                    weapon = Console.ReadLine();
                    if (int.TryParse(weapon, out int shootingChoice))
                    {
                        switch (shootingChoice)
                        {
                            case 1:
                                selectedWeapon = new AssaultRifle();
                                break;
                            case 2:
                                selectedWeapon = new LightMachineGun();
                                break;
                            case 3:
                                selectedWeapon = new Pistol();
                                break;
                            case 4:
                                selectedWeapon = new Shotgun();
                                break;
                            case 5:
                                selectedWeapon = new SniperRifle();
                                break;
                            case 6:
                                selectedWeapon = new SubmachineGun();
                                break;
                            // Add cases for other shooting weapons
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                    break;
                case 2:
                    Console.WriteLine("\tBomb\n\t\t1. Grenade \n\t\t2. Mine\n\tChemical\n\t\t3. Acid\n\t\t4. Mustard gas\n\t\t5. Tear gas\n\t\t6. VX\n\tRocket\n\t\t7. Bazooka\n\t\t8. RPG");
                    // Add cases for throwing weapons
                    break;
                case 3:
                    Console.WriteLine("\t1. Sword\n\t2. Axe\n\t3. Mace\n\t4. Bow\n\t5. Spear");
                    // Add cases for cold weapons
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Use the selected weapon if one was chosen
            if (selectedWeapon != null)
            {
                Console.WriteLine($"You have selected {selectedWeapon.Name}.");
                
                // Add any other code to use the selected weapon
            }
        }
    }

}
