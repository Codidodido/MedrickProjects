namespace BattleFront
{

    interface IBlister
    {
        void Blister(People victim,Chemical weapon);
    }

    interface INerve
    {
        void Nerve(People victim,Chemical weapon);
    }

    interface IBreath
    {
        void Breath(People victim,Chemical weapon);
    }
    
    public class Chemical : Weapon , IBreath , IBlister , INerve
    {
        public float BakeTime,Radius;

        public void Breath(People victim, Chemical weapon)
        {
            victim.Health -= weapon.Damage;
            victim.CanSee = false;
        }

        public void Nerve(People victim,Chemical weapon)
        {
            victim.Health -= weapon.Damage;
            victim.CanWalk = false;
        }

        public void Blister(People victim, Chemical weapon)
        {
            victim.Health -= weapon.Damage;
            victim.CanFocus = false;
        }
    }
}