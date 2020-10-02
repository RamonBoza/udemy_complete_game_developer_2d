using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f,10f)][SerializeField] private float gameSpeed = 1f;

    private void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
