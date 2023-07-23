using System;
namespace BattleFront
{
    interface IThrowRocket
    {
        void ShotRocket(People victim,Rocket attack);
    }
    public class Rocket : Throwing , IThrowRocket
    {
        public void ShotRocket(People victim, Rocket attack)
        {
            victim.Health -= attack.Damage;
            Console.WriteLine($"\n----\n{victim.Name} get attacked.\n\n-> Health: {victim.Health} | Damage: -{attack.Damage}");
        }
    }
}