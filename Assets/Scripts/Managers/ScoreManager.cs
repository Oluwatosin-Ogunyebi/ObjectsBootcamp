using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    private int _seconds;
    public UnityEvent OnScoreUpdated;
    public UnityEvent OnHighScoreUpdated;

    public string timer
    {
        get 
        { 
            return(Mathf.Round((float)_seconds / 60.0f) + "minutes and " + _seconds % 60 + "seconds");
        
        }

        private set { }
    }

    private int score;
    private int highScore;

    public int GetScore()
    {
        return score;
    }

    public int GetHighScore()
    {
        return highScore;
    }
    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HIGH_SCORE");
        OnHighScoreUpdated?.Invoke();
    }
    public void IncrementScore()
    {
        score++;
        OnScoreUpdated?.Invoke();

        if (score > highScore)
        {
            highScore = score;
            OnHighScoreUpdated?.Invoke();
            SetHighScore();
        }
    }

    public void SetHighScore()
    {
        PlayerPrefs.SetInt("HIGH_SCORE", highScore);
    }
}
