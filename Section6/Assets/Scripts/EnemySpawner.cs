using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<WaveConfig> _waveConfigs;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAllWaves());
    }

    private IEnumerator SpawnAllWaves()
    {
        foreach (WaveConfig wave in _waveConfigs)
        {
            yield return StartCoroutine(SpawnAllEnemiesInWave(wave));
        }
    }
    private IEnumerator SpawnAllEnemiesInWave(WaveConfig currentWave)
    {
        for (int currentEnemy = 0; currentEnemy < currentWave.GetNumberOfEnemies(); currentEnemy++)
        {
            var enemy = Instantiate(
                currentWave.GetEnemyPrefab(), 
                currentWave.GetWaypoints()[0].transform.position, 
                Quaternion.identity);
        
            enemy.GetComponent<EnemyPathing>().SetWaveConfig(currentWave);
            
            yield return new WaitForSeconds(currentWave.GetTimeBetweenSpawns());
        }
    }
}
