using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    WaveConfig waveConfig;
    List<Transform> wayPoints;
    
    int pathIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        wayPoints = waveConfig.GetPathPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    void MoveObject()
    {
        if(pathIndex <= wayPoints.Count - 1)
        {
            var targetPos = wayPoints[pathIndex].transform.position;
            var movement = waveConfig.GetMoveSpeed() * Time.deltaTime;
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
