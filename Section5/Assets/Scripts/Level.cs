using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int breakableBlocks; //to debug this number

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void DestroyBreakableBlocks()
    {
        breakableBlocks--;
    }
}
