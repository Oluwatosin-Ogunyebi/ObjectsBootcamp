using UnityEngine;

public class Enemy : PlayableObject
{
    private string name;
    private float speed;
    private Transform target;

    private EnemyType enemyType;
    public override void Move(Vector2 direction, Vector2 target)
    {
        Debug.Log($"Enemy is moving towards "); //{target.name}
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public override void Die()
    {
        Debug.Log($"Enemy died");
    }

    public override void Attack(float interval)
    {
        Debug.Log($"Enemy Attacking with a {interval} interval");
    }

    public void SetEnemyType(EnemyType enemyType)
    {
        this.enemyType = enemyType;
    }

    public override void GetDamage(float damage)
    {

    }
}
