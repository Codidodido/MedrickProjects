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
        public float RP { get; set; }
        public Attachment[] Equipment { get; set; }

        public void Info()
        {
            Console.WriteLine($"Gun {Name} : \n" +
                              $"Damage -> {Damage} | " +
                              $"FireRate -> {FireRate}\n" +
                              $"Mobility -> {Mobility} | " +
                              $"Range -> {Range}\n" +
                              $"Accuracy -> {Accuracy} | " +
                              $"Control -> {Control}\n" +
                              $"Ammunition -> {Ammunition} | " +
                              $"RP -> {RP}");
            Console.Write("Equipment -> ");
            foreach (var attachment in Equipment)
            {
                Console.Write($"| {attachment} |");
            }
            Console.WriteLine();
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