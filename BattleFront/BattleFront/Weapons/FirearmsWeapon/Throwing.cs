using BattleFront.Interfaces;
using System;
using System.Diagnostics;

namespace BattleFront
{
    public abstract class Throwing : Firearms, IWeaponInfo, IAttack
    {
        public float Radius { get; set; }
        
        public string sfx;

        public Throwing(string sfx, float radius)
        {
            this.sfx = sfx;
            Radius = radius;
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

        

        


        public virtual void Attack(People victim)
        {
            // Check distance
            
            if(Ammunition>0){
                if (victim.Health > 0)
                {
                    victim.Health -= Damage;
                    PlayWeaponAttackSound();
                }

            }
        }

        private void PlayWeaponAttackSound()
        {
            Console.WriteLine(sfx);
        }
    }
}