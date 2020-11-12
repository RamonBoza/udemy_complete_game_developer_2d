using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] private int starCost = 100;
    [SerializeField] private int amount = 3;

    public void AddStars()
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }
}
