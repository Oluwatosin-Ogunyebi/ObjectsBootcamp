using UnityEngine;
using System;

public class Health
{
    private float currentHealth;
    private float maxHealth;
    private float healthRegenRate;

    
    public Health(float _maxHealth = 100)
    {
        maxHealth = _maxHealth;
    }

    public Health(float _currentHealth, float _healthRegenRate, float _maxHealth)
    {
        currentHealth = _currentHealth;
        healthRegenRate = _healthRegenRate;
        maxHealth = _maxHealth;
    }

    public Health() { }

    public float GetHealth()
    {
        return currentHealth;
    }

    public void SetHealth(float value)
    {
        if (value > maxHealth || value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"A valid range of value for health is between 0 and {maxHealth}");
        }

        currentHealth = value;
    }

    public void RegenHealth()
    {
        AddHealth(healthRegenRate * Time.deltaTime);
    }

    public void AddHealth(float value)
    {
        currentHealth = Mathf.Min(currentHealth, currentHealth + value);
    }

    public void DeductHealth(float value)
    {
        currentHealth = Mathf.Max(0, currentHealth - value);
    }
}
