using BattleFront.Interfaces;
using System;
namespace BattleFront
{

    public class Chemical : Throwing
    {
        public float BakeTime { get; set; }

        public Chemical(string sfx, float radius) : base(sfx, radius)
        {
        }
    }
}