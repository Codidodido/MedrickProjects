using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip BreakSound;
    [SerializeField] GameObject blockSparkFLX;

    [SerializeField] int countHit;

    [SerializeField] Sprite[] Sprites;
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
            DestroyActive();
            
        }
        
    }

    private void DestroyActive()
    {
        countHit++;
        int maxHit = Sprites.Length+1;
        if (countHit >= maxHit)
        {
            DestroyBlock();
        }
        else
        {
            ShowNextSprite();
        }
    }
    private void ShowNextSprite()
    {
        int spriteIndex = countHit - 1;
        GetComponent<SpriteRenderer>().sprite = Sprites[spriteIndex];
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
