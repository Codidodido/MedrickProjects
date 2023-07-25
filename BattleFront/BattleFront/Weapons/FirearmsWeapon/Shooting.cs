using System;
using System.Collections.Generic;
using System.Linq;
using BattleFront.Equipment;
using BattleFront.Interfaces;

namespace BattleFront
{
    

    public class Shooting : Firearms, IWeaponInfo,IShot
    {
        //Round Per Second
        
        public Attachment[] Equipment { get; set; }

        public Shooting(string name, float range, float mobility, float firerate, float damage,int ammunition, float control,float accuracy,Attachment[] equipment)
        {
            Name = name;
            Range = range;
            Mobility = mobility;
            FireRate = firerate;
            Damage = damage;
            Ammunition = ammunition;
            Control = control;
            Accuracy = accuracy;
                Equipment = equipment;
        }
        

        public void Info()
        {
            Console.WriteLine($"---\nGun {Name} : \nDamage -> {Damage} | FireRate -> {{FireRate}}\n" +
                              $"Mobility -> {Mobility} | " +
                              $"Range -> {Range}\n" +
                              $"Accuracy -> {Accuracy} | " +
                              $"Control -> {Control}\n" +
                              $"Ammunition -> {Ammunition} | ");
                              Console.Write("Equipment -> ");
            foreach (var attachment in Equipment)
            {
                Console.Write($"| {attachment} |");
            }
            Console.WriteLine("\n---");
        }

        public void Shot(People victim)
        {
            Console.WriteLine($"---\nAttack with '{Name}' to Victim '{victim.Name}'.\n");
            if (Ammunition > 0)
            {
                Ammunition--;
                Console.WriteLine("-> Shot a bullet at victim.");
                victim.Health -= Damage;
                if (victim.Health > 0)
                {
                    
                    Console.WriteLine($"---\n-> Bullet hit victim {victim.Name}.\n--> Damage: {Damage}");
                    Console.WriteLine($"\n-> Victim '{victim.Name}' Situation: " +
                                      $"\n--> Health: {victim.Health}" +
                                      $"\n--> CanWalk: {victim.CanWalk}" +
                                      $"\n--> CanSee: {victim.CanSee}" +
                                      $"\n--> CanFocus: {victim.CanFocus}");
                    
                }
                else
                {
                    Console.WriteLine($"\n-> Victim '{victim.Name} died. '");
                }
                
                Console.WriteLine($"\n-> Weapon {Name} Situation:");
                Info();
                
            }
            else
            {
                Console.WriteLine($"\n-> Victim '{victim.Name} died. '");
            }
        }

        
    }
}