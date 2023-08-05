using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    [SerializeField] List<Transform> way;
    [SerializeField] float MoveSpeed;
    int pathIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = way[pathIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    void MoveObject()
    {
        if(pathIndex <= way.Count - 1)
        {
            var targetPos = way[pathIndex].transform.position;
            var movement = MoveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPos, movement);

            if(transform.position == targetPos)
            {
                pathIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
