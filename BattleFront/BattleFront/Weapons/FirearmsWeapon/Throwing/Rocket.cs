using System;
using System.Threading;

namespace BattleFront
{
    
    public class Rocket : Throwing
    {
        //ms
        public int ReloadTime;

        public Rocket(string sfx, float radius) : base(sfx, radius)
        {
        }
        
        public override void Attack(People victim)
        {
            Thread.Sleep(ReloadTime);
            base.Attack(victim);
        }
    }
}