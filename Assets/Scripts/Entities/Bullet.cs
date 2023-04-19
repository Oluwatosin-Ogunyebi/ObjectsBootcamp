using UnityEngine;

public class Bullet
{
    private float damage;

    void Move(Transform target)
    {
        Debug.Log($"Bullet is moving towards {target.name} to deal a damage of {damage}");
    }

    void Damage()
    {
        Debug.Log("Damaged Something!");
    }
}
