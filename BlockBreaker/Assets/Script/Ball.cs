using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Paddle paddle;
    Vector2 PaddleToBall;
    bool hasStart = false;
    [SerializeField] float xPush , yPush;
    [SerializeField] List<AudioClip> ClipList = new List<AudioClip>();
    void Start()
    {
        PaddleToBall = transform.position - paddle.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStart)
        {
            int randomIndex = Random.Range(0,ClipList.Count);
            GetComponent<AudioSource>().PlayOneShot(ClipList[randomIndex]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStart)
        {
            LockOnPaddle();
            LaunchBall();
        }
    }

    void LockOnPaddle()
    {
        Vector2 PaddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = PaddlePos + PaddleToBall;
    }

    void LaunchBall()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStart = true;
        }
    }
}
