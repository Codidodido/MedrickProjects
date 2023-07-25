using BattleFront.Interfaces;

namespace BattleFront.ChemicalWeapon
{
    public class DistractThrow : Throwing,IDistract
    {
        public DistractThrow(string sfx, float radius) : base(sfx, radius)
        {
        }

        public void Blister(People victim)
        {
            victim.CanFocus = false;
        }

        public override void Attack(People victim)
        {
            base.Attack(victim);
            Blister(victim);
        }
    }
}