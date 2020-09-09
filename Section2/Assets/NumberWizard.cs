using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    
    int max = 1000;
    int min = 1;
    int guess = 500;
    
    void Start()
    {
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Tell me if your number is higher or lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Tell me if your number is higher or lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genious.");
        }
    }
}
