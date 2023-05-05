using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup, IDamageable
{
    [SerializeField] public int healthMin;
    [SerializeField] public int healthMax;

    public override void OnPicked()
    {
        base.OnPicked();

        //TO DO: Increase Health Here
        float health = Random.Range(healthMin, healthMax);

        var player = GameManager.GetInstance().GetPlayer();

        player.health.AddHealth(health);

        Debug.Log($"Added {health} to Player");
    }

    public void GetDamage(float damage)
    {
        OnPicked();
    }
}
