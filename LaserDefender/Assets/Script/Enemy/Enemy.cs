using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float Health = 100;
    [SerializeField] GameObject Laser;
    [SerializeField] GameObject deathVFX;
    [SerializeField] float LaserSpeed;
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
        Destroy(gameObject);
        GameObject destroyEffect = Instantiate(deathVFX,transform.position, Quaternion.identity);
        Destroy(destroyEffect, 1f);
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
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -LaserSpeed);
            yield return new WaitForSeconds(0.75f);
            
        }


    }


}
