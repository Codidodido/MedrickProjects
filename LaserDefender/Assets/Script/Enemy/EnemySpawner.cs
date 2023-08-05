using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfig;
    int startWave = 0;
    [SerializeField] bool loop;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        //var currentWave = waveConfig[startWave];
        //StartCoroutine(SpawnEnemies(currentWave));
        do
        {
           yield return StartCoroutine(SpawnWaves());
        } while (loop);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpawnWaves()
    {
        for(int index = 0;index< waveConfig.Count;index++)
        {
            var CurrentWave = waveConfig[index];
            yield return StartCoroutine(SpawnEnemies(CurrentWave));
        }
    }
    private IEnumerator SpawnEnemies(WaveConfig wave)
    {
        var EnemyNumbers = wave.GetEnemiesNumber();
        for(int i = 0; i < EnemyNumbers; i++)
        {
            var Enemy = Instantiate(wave.GetEnemyPrefab(), wave.GetPathPrefab()[0].transform.position, Quaternion.identity);
            Enemy.GetComponent<EnemyPath>().SetWaveConfig(wave);
            yield return new WaitForSeconds(wave.GetTimeBetweenSpawns());
        }
        
    }
}
