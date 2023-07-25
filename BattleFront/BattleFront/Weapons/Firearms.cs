using System;
using System.Runtime.ConstrainedExecution;

namespace BattleFront
{
    
    public class Firearms : Weapon
    {
        public float Accuracy{ get; set; }
        public float Control{ get; set; }
        public int Ammunition{ get; set; }
        
    }
}