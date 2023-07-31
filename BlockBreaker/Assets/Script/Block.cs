using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip BreakSound;
    [SerializeField] GameObject blockSparkFLX;
    Level level;
    
    private void Start()
    {
        level = FindObjectOfType<Level>();
        if (tag == "breakable")
        {
            level.CounterBreakableBlocks();
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "breakable")
        {
            DestroyBlock();
        }
        
    }

    private void DestroyBlock()
    {
        PlaySoundOnDestroy();
        level.DecreaseBreakableBlocks();
        DestroyAct();
    }

    private void PlaySoundOnDestroy()
    {
        FindObjectOfType<GameStatus>().AddScore();
        AudioSource.PlayClipAtPoint(BreakSound, Camera.main.transform.position);
    }

    private void PlayVFX()
    {
        GameObject VFX = Instantiate(blockSparkFLX, transform.position, transform.rotation);
        Destroy(VFX, 1f);
    }

    private void DestroyAct()
    {
        PlayVFX();
        Destroy(gameObject);
    }
}
