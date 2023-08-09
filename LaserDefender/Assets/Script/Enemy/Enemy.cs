using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float Health = 100;
    [SerializeField] GameObject Laser;
    [SerializeField] GameObject deathVFX;
    [SerializeField] float LaserSpeed;
    [SerializeField] AudioClip DeathSound;
    [SerializeField] AudioClip LaseSound;
    [SerializeField] int Point;
    private int Damage = 42; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer damagedeal = collision.gameObject.GetComponent<DamageDealer>();
        ProcessHit(damagedeal);
    }

    void ProcessHit(DamageDealer damagedeal)
    {
        Health -= damagedeal.GetDamage();
        if (Health <= 0)
        {
            Die();   
        }
    }

    void Die()
    {
        FindObjectOfType<GameSession>().AddScore(Point);
        Destroy(gameObject);
        GameObject destroyEffect = Instantiate(deathVFX,transform.position, Quaternion.identity);
        Destroy(destroyEffect, 1f);
        AudioSource.PlayClipAtPoint(DeathSound,Camera.main.transform.position,0.75f);
    }

    private void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {

            //Destroy(laser, 1f);
            GameObject laser = Instantiate(Laser, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(LaseSound, Camera.main.transform.position, 0.25f);
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -LaserSpeed);
            yield return new WaitForSeconds(0.75f);
            
        }


    }


}
