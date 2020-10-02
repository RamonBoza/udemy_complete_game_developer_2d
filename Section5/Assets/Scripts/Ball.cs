using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //configuration
    [SerializeField] private Paddle paddle;
    [SerializeField] private float xPush = 2f;
    [SerializeField] private float yPush = 15f;
    
    // state
    private Vector2 distanceToBallVector;

    private bool hasStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        distanceToBallVector = transform.position - paddle.transform.position;
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
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
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
            GetComponent<AudioSource>().Play();
        }
    }
}
