using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float screenWidthInUnits = 16f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(Input.mousePosition.x / Screen.width * screenWidthInUnits, transform.position.y );
        transform.position = paddlePos;
    }
}
