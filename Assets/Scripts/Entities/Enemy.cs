using UnityEngine;
using System;

public class Enemy : PlayableObject
{
    private string enemyName;


    [SerializeField] protected float speed;
    protected Transform target;

    private EnemyType enemyType;

    protected virtual void Start()
    {
        try
        {
            target = GameObject.FindWithTag("Player").transform;
        }
        catch (NullReferenceException e)
        {

            Debug.Log("Player does not exist again " + e);
        }
       
    }

    protected virtual void Update()
    {
        if (target != null)
        {
            Move(target.position);
        }
        else
        {
            Move(speed);
        }
    }
    public override void Move(Vector2 direction, Vector2 target)
    {
        Debug.Log($"Enemy is moving towards "); //{target.name}
    }

    public override void Move(float speed)
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }

    public override void Move(Vector2 direction)
    {
        direction.x -= transform.position.x;
        direction.y -= transform.position.y;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }
    public override void Shoot()
    {
        Debug.Log($"Shooting a bullet");
    }

    public override void Die()
    {
        Debug.Log($"Enemy died");
        GameManager.GetInstance().NotifyDeath(this);
        Destroy(gameObject);
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
        Debug.Log("Enemy Damaged!");
        health.DeductHealth(damage);
        if (health.GetHealth() <= 0)
        {
            Die();
        }
    }

    /// <summary>
    /// 
    /// </summary>
}
