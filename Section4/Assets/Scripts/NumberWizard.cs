using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private int max;
    [SerializeField] private int min;
    [SerializeField] private TextMeshProUGUI guessText;
    int guess;
    
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = max + 1;
        NextGuess();
    }
    
    // Update is called once per frame
    public void OnPressHigher()
    {
            min = guess;
            NextGuess();
    }

    public void OnPressLower()
    {
            max = guess;
            NextGuess();
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}
