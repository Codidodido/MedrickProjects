using BattleFront.Interfaces;
using System;

namespace BattleFront
{
    public class Throwing : Firearms, IWeaponInfo, IThrow , IBreath , IBlister , INerve
    {
        public float Radius { get; set; }
        public string Type;
        
        public void Breath(People victim)
        {
            victim.Health -= Damage;
            victim.CanSee = false;
        }

        public void Nerve(People victim)
        {
            victim.Health -= Damage;
            victim.CanWalk = false;
        }

        public void Blister(People victim)
        {
            victim.Health -= Damage;
            victim.CanFocus = false;
        }
        
        public void Info()
        {
            Console.WriteLine($"Gun {Name} : \n" +
                              $"Damage -> {Damage} | " +
                              $"FireRate -> {FireRate}\n" +
                              $"Mobility -> {Mobility} | " +
                              $"Range -> {Range}\n" +
                              $"Accuracy -> {Accuracy} | " +
                              $"Control -> {Control}\n" +
                              $"Ammunition -> {Ammunition}");
            Console.WriteLine();
        }

        

        public void Throw(People victim)
        {
            
            Console.WriteLine($"\n----\n{victim.Name} get attacked By {Name}('{Type}') Weapon.");
            if(Ammunition>0){
                if (Type == "Nerve")
                {
                    Nerve(victim);
                }else if (Type == "Blister")
                {
                    Blister(victim);
                }
                else
                {
                    Breath(victim);
                }
                if (victim.Health > 0)
                {
                    
                    Console.WriteLine($"---\n-> Object hit victim {victim.Name}.\n--> Damage: {Damage}");
                    Console.WriteLine($"\n-> Victim '{victim.Name}' Situation: " +
                                      $"\n--> Health: {victim.Health}" +
                                      $"\n--> CanWalk: {victim.CanWalk}" +
                                      $"\n--> CanSee: {victim.CanSee}" +
                                      $"\n--> CanFocus: {victim.CanFocus}");
                        
                }
                else
                {
                    Console.WriteLine($"\n-> Victim {victim.Name} died.");
                }

            }
            else
            {
                Console.WriteLine("Not Enough Ammu !");
            }
        }

        
    }
}