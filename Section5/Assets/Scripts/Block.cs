using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{

    [SerializeField] private AudioClip breakSound;

    private Level level;
    private GameStatus _gameStatus;

    private void Start()
    {
        _gameStatus = FindObjectOfType<GameStatus>();
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.DestroyBreakableBlocks();
        _gameStatus.AddToScore();
        Destroy(gameObject);
    }
}
