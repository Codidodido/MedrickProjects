using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float RotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * RotateSpeed);
    }
}
