using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<WaveConfig> _waveConfigs;

    private int startingWave = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        var currentWave = _waveConfigs[startingWave];
        StartCoroutine(SpawnAllEnemiesInWave(currentWave));
    }

    private IEnumerator SpawnAllEnemiesInWave(WaveConfig currentWave)
    {
        for (int currentEnemy = 0; currentEnemy < currentWave.GetNumberOfEnemies(); currentEnemy++)
        {
            Instantiate(
                currentWave.GetEnemyPrefab(), 
                currentWave.GetWaypoints()[0].transform.position, 
                Quaternion.identity);
        
            yield return new WaitForSeconds(currentWave.GetTimeBetweenSpawns());
        }
    }
}
