using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    private int _seconds;
    public UnityEvent OnScoreUpdated;

    public string timer
    {
        get 
        { 
            return(Mathf.Round((float)_seconds / 60.0f) + "minutes and " + _seconds % 60 + "seconds");
        
        }

        private set { }
    }

    private int score;

    public int GetScore()
    {
        return score;
    }
    
    public void IncrementScore()
    {
        score++;
        OnScoreUpdated?.Invoke();
    }
}
