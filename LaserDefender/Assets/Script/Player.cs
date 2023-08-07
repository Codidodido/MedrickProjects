using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [Header ("Player")]
    [SerializeField] float moveSpeed;
    [SerializeField] AudioClip Damage;
    [SerializeField] float Health = 200;
    [SerializeField] GameObject deathVFX;
    [SerializeField] AudioClip DeathSound;
    [SerializeField] int Score;
    Coroutine fireCoroutine;
    // Update is called once per frame

    [Header ("Laser")]
    [SerializeField] GameObject Laser;
    [SerializeField] Vector2 LaserPos;
    [SerializeField] float LaserSpeed;
    [SerializeField] AudioClip Lasersound;
    [SerializeField][Range(0f, 1f)] float LasersoundVolume;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer damagedeal = collision.gameObject.GetComponent<DamageDealer>();
        AudioSource.PlayClipAtPoint(Damage, Camera.main.transform.position, 0.75f);
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

    private void Die()
    {
        FindObjectOfType<Level>().LoadGameOver();
        Destroy(gameObject);
        GameObject destroyEffect = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(destroyEffect, 1f);
        AudioSource.PlayClipAtPoint(DeathSound, Camera.main.transform.position, 0.75f);
    }

    void Update()
    {
        Move();
        Fire();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var newXpos = transform.position.x + deltaX;
        var newYpos = transform.position.y + deltaY;
        transform.position = new Vector2(newXpos,newYpos);
    }

    private void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fireCoroutine =  StartCoroutine(FireContinuously());
            
        }else if (Input.GetMouseButtonUp(0))
        {
            StopCoroutine(fireCoroutine);
        }
        
    }

    IEnumerator FireContinuously()
    {
        while (true)
        {
            GameObject laser = Instantiate(Laser, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(Lasersound, Camera.main.transform.position, LasersoundVolume);
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, LaserSpeed);
            //Destroy(laser, 1f);
            yield return new WaitForSeconds(0.1f);
        }
        

    }
}
