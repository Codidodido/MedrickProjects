using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int enemiesNumber=5;
    [SerializeField] float moveSpeed=2f;

    public GameObject GetEnemyPrefab(){return enemyPrefab;}
    public List<Transform> GetPathPrefab() {
        var Wave = new List<Transform>();
        foreach(Transform child in pathPrefab.transform)
        {
            Wave.Add(child);
            
        }
        return Wave;
    }
    public float GetTimeBetweenSpawns(){return timeBetweenSpawns;}
    public float GetSpawnRandomFactor() { return spawnRandomFactor;}
    public int GetEnemiesNumber() { return enemiesNumber;}
    public float GetMoveSpeed() { return moveSpeed;}


}
