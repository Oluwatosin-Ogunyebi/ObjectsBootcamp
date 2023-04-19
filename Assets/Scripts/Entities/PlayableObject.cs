using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableObject : MonoBehaviour, IDamageable
{
    //Composition (part of)
    public Health health = new Health();
    public Weapon weapon;
    public abstract void Move(Vector2 direction, Vector2 target);

    public abstract void Shoot(Vector3 direction, float speed);

    public abstract void Die();

    public abstract void Attack(float interval);

    public abstract void GetDamage(float damage);
}
