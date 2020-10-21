using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create Wave Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] private GameObject enemyPrefab;

    public GameObject EnemyPrefab
    {
        get => enemyPrefab;
        set => enemyPrefab = value;
    }

    public GameObject PathPrefab
    {
        get => pathPrefab;
        set => pathPrefab = value;
    }

    public float TimeBetweenSpawns
    {
        get => timeBetweenSpawns;
        set => timeBetweenSpawns = value;
    }

    public float SpawnRandomFactor
    {
        get => spawnRandomFactor;
        set => spawnRandomFactor = value;
    }

    public int NumberOfEnemies
    {
        get => numberOfEnemies;
        set => numberOfEnemies = value;
    }

    public float MoveSpeed
    {
        get => moveSpeed;
        set => moveSpeed = value;
    }

    [SerializeField] private GameObject pathPrefab;
    [SerializeField] private float timeBetweenSpawns = 0.5f;
    [SerializeField] private float spawnRandomFactor = 0.3f;
    [SerializeField] private int numberOfEnemies = 10;
    [SerializeField] private float moveSpeed = 2f;


}
