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
    void Update()
    {
        float mousePos = Input.mousePosition.x / Screen.width * WidthPerUnit-8;
        Vector2 newPos = new Vector2(transform.position.x, transform.position.y);
        newPos.x = Mathf.Clamp(mousePos, Lim, Max);
        transform.position = newPos;
    }
}
