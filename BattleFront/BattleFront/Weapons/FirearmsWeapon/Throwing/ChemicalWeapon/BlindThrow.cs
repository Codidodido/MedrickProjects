using BattleFront.Interfaces;

namespace BattleFront.ChemicalWeapon
{
    public class BlindThrow : Throwing, IBlind
    {
        public BlindThrow(string sfx, float radius) : base(sfx, radius)
        {
        }

        public void Blind(People victim)
        {
            victim.CanSee = false;
        }

        public override void Attack(People victim)
        {
            base.Attack(victim);
            Blind(victim);
        }
    }
}