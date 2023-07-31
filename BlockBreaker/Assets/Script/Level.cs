using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int BreakableBlocks;
    [SerializeField] SceneLoader Loader;

    private void Start()
    {
        Loader = FindObjectOfType<SceneLoader>();
    }

    public void CounterBreakableBlocks()
    {
        BreakableBlocks++;
    }

    public void DecreaseBreakableBlocks()
    {
        BreakableBlocks--;
        if(BreakableBlocks <= 0)
        {
            Loader.LoadNextScene();
        }
    }


}
