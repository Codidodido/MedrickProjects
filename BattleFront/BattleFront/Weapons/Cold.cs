using System;
using BattleFront.Interfaces;

namespace BattleFront
{
    public class Cold : Weapon , IAttack
    {

        public void Attack(People victim)
        {
            Console.WriteLine($"---\n-> Victim {victim.Name} attacked by {Name} and receive {Damage} damage.");
            victim.Health -= Damage;
            if (victim.Health > 0)
            {
                
                
                Console.WriteLine($"\n-> Victim '{victim.Name}' Situation: " +
                                  $"\n--> Health: {victim.Health}" +
                                  $"\n--> CanWalk: {victim.CanWalk}" +
                                  $"\n--> CanSee: {victim.CanSee}" +
                                  $"\n--> CanFocus: {victim.CanFocus}");
            }
            else
            {
                Console.WriteLine($"-> Victim {victim.Name} died.");
            }
        }
    }
}