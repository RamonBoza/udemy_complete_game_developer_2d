using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Ball : MonoBehaviour
{
    //configuration
    [SerializeField] private Paddle paddle;
    [SerializeField] private float xPush = 2f;
    [SerializeField] private float yPush = 15f;
    [SerializeField] private AudioClip[] ballSounds;
    
    // state
    private Vector2 distanceToBallVector;
    private bool hasStarted = false;
    
    // Cached components
    private AudioSource myAudioSource;
    private Rigidbody2D myRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        distanceToBallVector = transform.position - paddle.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToThePaddle();
            LaunchOnMouseClick();
        }
        
    }

    void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigidBody.velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }

    void LockBallToThePaddle()
    {
        Vector2 paddlePos = paddle.transform.position;
        Vector2 ballPos = paddlePos + distanceToBallVector;
        transform.position = ballPos;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (hasStarted)
        {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0,ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
        }
    }
}
