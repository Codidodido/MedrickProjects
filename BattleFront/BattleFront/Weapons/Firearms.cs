using System;
using System.Runtime.ConstrainedExecution;

namespace BattleFront
{
    interface IShot
    {
        void FireShot(People victim,Firearms attack);
    }
    public class Firearms : Weapon,IShot
    {
        public float Accuracy, Control;
        public int Ammunition;

        public void FireShot(People victim, Firearms attack)
        {
            victim.Health -= attack.Damage;
            Console.WriteLine($"\n----\n{victim.Name} get attacked.\n\n-> Health: {victim.Health} | Damage: -{attack.Damage}");
        }
        
        
    }
}