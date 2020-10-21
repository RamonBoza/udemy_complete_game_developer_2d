using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    private WaveConfig _waveConfig;
    private int waypointIndex = 0;

    private void Start()
    {
        var waypoints = _waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        Move();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this._waveConfig = waveConfig;
    }
    private void Move()
    {
        var waypoints = _waveConfig.GetWaypoints();
        var moveSpeed = _waveConfig.GetMoveSpeed();
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointIndex].transform.position;
            var movementThisFrame = moveSpeed * Time.deltaTime;
            transform.position =
                Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);

            if (transform.position == targetPosition) waypointIndex++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
