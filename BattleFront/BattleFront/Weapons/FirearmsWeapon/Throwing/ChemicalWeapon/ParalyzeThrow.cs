using BattleFront.Interfaces;

namespace BattleFront.ChemicalWeapon
{
    public class ParalyzeThrow : Throwing , IParalyze
    {
        public ParalyzeThrow(string sfx, float radius) : base(sfx, radius)
        {
            
        }

        public void Paralyze(People victim)
        {
            victim.CanWalk = false;
        }

        public override void Attack(People victim)
        {
            base.Attack(victim);
            Paralyze(victim);
        }
    }
}