using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        ResetAllButtons();
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void ResetAllButtons()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (var button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(42, 42, 42, 255);
        }
    }
}
