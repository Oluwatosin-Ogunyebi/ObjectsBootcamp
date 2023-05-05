using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] private TMP_Text txtHealth;
    [SerializeField] private TMP_Text txtScore;
    private void Start()
    {   
        //Subscribing to action
        player.health.OnHealthUpdate += UpdateHealth;
    }
    private void OnDisable()
    {   
        //Unsubscribing to action
        player.health.OnHealthUpdate -= UpdateHealth;
    }

    public void UpdateHealth(float currentHealth)
    {
        txtHealth.SetText(currentHealth.ToString());
    }

    public void UpdateScore()
    {
        //Update Score
        txtScore.SetText(GameManager.GetInstance().scoreManager.GetScore().ToString());
    }
}
