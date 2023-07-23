using System;

namespace BattleFront
{
    interface IThrowBomb
    {
        void Throw(People victim,Bomb attack);
    }
    public class Bomb : Throwing,IThrowBomb
    {
        public void Throw(People victim,Bomb attack)
        {
            victim.Health -= attack.Damage;
            Console.WriteLine($"\n----\n{victim.Name} get attacked.\n\n-> Health: {victim.Health} | Damage: -{attack.Damage}");
        }
    }
}