using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //configuration
    [SerializeField] private Paddle paddle;
    
    // state
    private Vector2 distanceToBallVector;
    // Start is called before the first frame update
    void Start()
    {
        distanceToBallVector = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = paddle.transform.position;
        Vector2 ballPos = paddlePos + distanceToBallVector;
        transform.position = ballPos;
    }
}
