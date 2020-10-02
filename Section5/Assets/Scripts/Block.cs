using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{

    [SerializeField] private AudioClip breakSound;

    private Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.DestroyBreakableBlocks();
        Destroy(gameObject);
    }
}
