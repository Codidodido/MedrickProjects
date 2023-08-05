using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed;
    [SerializeField] GameObject Laser;
    [SerializeField] Vector2 LaserPos;
    [SerializeField] float LaserSpeed;

    Coroutine fireCoroutine;
    // Update is called once per frame
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
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, LaserSpeed);
            //Destroy(laser, 1f);
            yield return new WaitForSeconds(0.5f);
        }
        

    }
}
