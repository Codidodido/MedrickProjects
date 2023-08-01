using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float WidthPerUnit;
    [SerializeField] float Lim, Max;

    // Update is called once per frame

    private void Start()
    {
        
    }
    void Update()
    {

        float mousePos = GetX();
        Vector2 newPos = new Vector2(transform.position.x, transform.position.y);
        newPos.x = Mathf.Clamp(mousePos, Lim, Max);
        transform.position = newPos;
    }

    float GetX()
    {
        if (FindObjectOfType<GameStatus>().AutoPlay)
        {
            return FindObjectOfType<Ball>().transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * WidthPerUnit - 8;
        }
    }
}
