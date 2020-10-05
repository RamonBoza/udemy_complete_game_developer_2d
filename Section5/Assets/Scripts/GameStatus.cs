using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    //elements
    [SerializeField] private TextMeshProUGUI scoreText;
    //config parameters
    [Range(0.1f,10f)][SerializeField] private float gameSpeed = 1f;
    [SerializeField] private int pointsPerBlockedDestroyed = 83;
    
    //state
    [SerializeField] private int currentScore = 0;

    private void Start()
    {
        scoreText.text = currentScore.ToString(); 
    }

    private void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockedDestroyed;
        scoreText.text = currentScore.ToString();
    }
}
