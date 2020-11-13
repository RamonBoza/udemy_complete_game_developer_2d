using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject gun;
    [SerializeField] private GameObject projectile;
    private AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("shoot pew pew");
        }
        else
        {
            Debug.Log("sit and wait");
        }
    }

    private bool IsAttackerInLane()
    {
        return myLaneSpawner.transform.childCount > 0;
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (var attackerSpawner in spawners)
        {
            bool isCloseEnough = (Mathf.Abs(Mathf.Floor(attackerSpawner.transform.position.y ) - Mathf.Floor(transform.position.y)) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = attackerSpawner;
                return;
            }
        }
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
}
