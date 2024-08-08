using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Added Text Mesh Pro name to access unity library

public class ScoreManager : MonoBehaviour
{
    public int score; // Score Value

    public TextMeshProUGUI scoreText; // Visual text element to be modified

    public void IncreaseScore(int amount) // Increases score based on score variable
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // Decreases score based on score variable
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // Updates the score in the HUD UI text
    {
        scoreText.text = "Score: " + score;
    }
    
}
