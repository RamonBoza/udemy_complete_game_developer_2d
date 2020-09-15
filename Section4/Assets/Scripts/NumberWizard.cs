using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms;

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
        NextGuess();
        max = max + 1;
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
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
