using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip BreakSound;
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CounterBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(BreakSound, Camera.main.transform.position);
        level.DecreaseBreakableBlocks();
        Destroy(gameObject);
    }
}
