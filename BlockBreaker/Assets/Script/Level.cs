using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int BreakableBlocks;

    public void CounterBreakableBlocks()
    {
        BreakableBlocks++;
    }

    public void DecreaseBreakableBlocks()
    {
        BreakableBlocks--;
    }
}
