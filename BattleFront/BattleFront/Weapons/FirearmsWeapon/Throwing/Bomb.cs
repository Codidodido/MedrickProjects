using System;

namespace BattleFront
{
    
    public class Bomb : Throwing
    {
        public bool Explosion;

        public Bomb(string sfx, float radius) : base(sfx, radius)
        {
            
        }

        public override void Attack(People victim)
        {
            if (Explosion)
            {
                base.Attack(victim);    
            }
            
        }
    }
}