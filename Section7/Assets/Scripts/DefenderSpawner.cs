using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject defender;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SpawnDefender();
    }

    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(defender, Vector2.zero, Quaternion.identity);
    }
}
