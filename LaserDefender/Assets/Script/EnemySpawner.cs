using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfig;
    int startWave = 0;
    // Start is called before the first frame update
    void Start()
    {
        var currentWave = waveConfig[startWave];
        StartCoroutine(SpawnEnemies(currentWave));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemies(WaveConfig wave)
    {
        var EnemyNumbers = wave.GetEnemiesNumber();
        for(int i = 0; i < EnemyNumbers; i++)
        {
            GameObject Enemy = Instantiate(wave.GetEnemyPrefab(), wave.GetPathPrefab()[0].transform.position, Quaternion.identity);
            Enemy.GetComponent<EnemyPath>().SetWaveConfig(wave);
            yield return new WaitForSeconds(wave.GetTimeBetweenSpawns());
        }
        
    }
}
