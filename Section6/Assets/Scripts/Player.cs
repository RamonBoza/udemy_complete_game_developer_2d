using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float padding = 1f;

    private float xMin, xMax, yMin, yMax;
    private void Start()
    {
        SetUpMoveBoundaries();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        var newXPos = Mathf.Clamp(transform.position.x + deltaX,xMin,xMax);
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);

        transform.position = new Vector2(newXPos, newYPos);

    }

    public void SetUpMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        var lowerCorner = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
        var topCorner = gameCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

        xMin = lowerCorner.x + padding;
        xMax = topCorner.x - padding;
        yMin = lowerCorner.y + padding;
        yMax = topCorner.y - padding;
    }
}
