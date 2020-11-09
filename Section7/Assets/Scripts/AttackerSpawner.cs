using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AttackerSpawner : MonoBehaviour
{
    private bool spawn = true;
    [SerializeField] private float minSpawnDelay = 1f;
    [SerializeField] private float maxSpawnDelay = 5f;
    [SerializeField] private Attacker attackerPrefab;


    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            Spawn();
        }    
    }

    private void Spawn()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
