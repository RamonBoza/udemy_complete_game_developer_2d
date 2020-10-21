using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float backgroundScrollSpeed = 0.5f;
    private Material background;
    private Vector2 offset;

    private void Start()
    {
        background = GetComponent<Renderer>().material;
        offset = new Vector2(0, backgroundScrollSpeed);
    }

    private void Update()
    {
        background.mainTextureOffset += offset * Time.deltaTime;
    }
}
