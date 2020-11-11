using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] private int stars = 100;
    private Text starText;
    
    void Start()
    {
        starText = GetComponent<Text>();
    }

    private void UpdateDisplays()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplays();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplays();    
        }
    }
}
