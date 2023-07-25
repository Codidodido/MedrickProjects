using System;
using System.Collections.Generic;
using BattleFront.ChemicalWeapon;

using BattleFront.Equipment;
using BattleFront.Interfaces;


namespace BattleFront
{

    
    internal class Program 
    {
        
        
        public static void Main(string[] args)
        {
            // void AddToGunInventory(string name, float range, float mobility, float firerate, float damage,int ammunition, float control,float accuracy,Attachment[] equipment)
            // {
            //     Shooting gun = new Shooting(name, range, mobility, firerate, damage, ammunition, control, accuracy,
            //         equipment);
            //     Object = new Inventory<Shooting>();
            //     Object.Object = new List<Shooting>();
            //     Object.Object.Add(gun);
            //     
            // }
            
            
            Console.WriteLine("WELCOME TO BATTLEFRONT GAME");
            Console.WriteLine("\nChoose your weapon type: ");
            Console.WriteLine("\t1. Shooting\n\t2. Throwing\n\t3. Cold");
            int Type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose your weapon: ");
            int selectweapon;

            Shooting Gun = new Shooting("",0,0,0,0,0,0,0,new[] { Attachment.Barrel });
            Cold Weapon = new Cold("",0,0,0,0);
            Bomb Bomb = new Bomb("",0);
            
            
            switch (Type)
            {
                case 1:
                    Console.WriteLine("\t1. Assault rifle\n\t2. Light machine gun\n\t3. Pistol\n\t4. Shotgun\n\t5. Sniper rifle\n\t6. Sub machine gun");
                    selectweapon = Convert.ToInt32(Console.ReadLine());
                    switch (selectweapon)
                    {
                        case 1:
                            //Assault Rifle
                            Gun = new Shooting("AK47", 85, 80, 70, 65, 40, 80, 75, new[] { Attachment.Barrel });
                            break;
                        case 2:
                            //Light Machine Gun
                            Gun = new Shooting("M249", 90, 85, 50, 50, 100, 90, 70, new[] { Attachment.Barrel });
                            break;
                        case 3:
                            //Pistol
                            Gun = new Shooting("Desert", 50, 100, 70, 30, 7, 100, 89, new[] { Attachment.Barrel });
                            break;
                        case 4:
                            //Shotgun
                            Gun = new Shooting("Remington870", 50, 50, 30, 85, 8, 70, 50,new[] { Attachment.Barrel });
                            break;
                        case 5:
                            //Sniper rifle
                            Gun = new Shooting("M21", 100, 50, 20, 95, 5, 70, 90, new[] { Attachment.Barrel });
                            break;
                        case 6:
                            //Sub machine gun
                            Gun = new Shooting("Uzi", 95, 100, 80, 30, 80, 30, 40, new[] { Attachment.Barrel });
                            break;
                        default:
                            Console.WriteLine("Not valid. Try again!");
                            break;
                    }
                    
                    Gun.Info();
                    break;
                case 2:
                    Console.WriteLine("\t1. Sword\n\t2. Axe\n\t3. Mace\n\t4. Bow\n\t5. Spear");
                    selectweapon = Convert.ToInt32(Console.ReadLine());
                    switch (selectweapon)
                    {
                        case 1:
                            //Sword
                            Weapon = new Cold("Sword",52,30,60,1);
                            break;
                        case 2:
                            //Axe
                            Weapon = new Cold("Axe",58,10,30,3);
                            break;
                        case 3:
                            //Mace
                            Weapon = new Cold("Sword",52,30,60,1);
                            break;
                        case 4:
                            //Bow
                            Weapon = new Cold("Bow",30,50,80,20);
                            break;
                        case 5:
                            //Spear
                            Weapon = new Cold("Spear",42,40,100,2);
                            break;
                        default:
                            Console.WriteLine("Not valid. Try again!");
                            break;
                    }
                    Console.WriteLine($"Weapon {Weapon.Name} selected!");
                    break;
                case 3:
                    break;
            }
            Inventory<Shooting> gunInventory = new Inventory<Shooting>();

            
            Shooting uzi = new Shooting("Uzi", 95, 100, 80, 30, 80, 30, 40, new[] { Attachment.Barrel });
            gunInventory.AddToInventory(uzi);


            foreach (var gun in gunInventory.Items)
            {
                gun.Info();
            }

            People target = new People
            {
                Health = 100,
                CanWalk = true,
                CanSee = true,
                CanFocus = true,
                Name = "Alex"
            };
            int order = 1;
            
            
            
            
            while (order!=0 &&  target.Health>0)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("\t-> 1. Attack to enemy\n\t-> 2. Drop\n\t-> 3. Look for gun\n\n\t-> 0. Exit");
                order = Convert.ToInt32(Console.ReadLine());
                switch (order)
                {
                    case 0:
                        return;
                        break;
                    case 1:
                        Gun.Shot(target);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                {
                    
                }
            }
            


        }
    }

}
