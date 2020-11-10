using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject defender;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SpawnDefender();
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(defender, GetSquareClicked(), Quaternion.identity);
    }
}
