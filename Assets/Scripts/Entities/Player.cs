using UnityEngine;
using System;

public class Player : PlayableObject //Inheritance (is a)
{
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;

    [SerializeField] private float weaponDamage = 1;
    [SerializeField] private float bulletSpeed = 10;
    [SerializeField] private Bullet bulletPrefab;
    private Rigidbody2D playerRB;

    
    public void Awake()
    {
        health = new Health(100, 0.05f,100);
        playerRB = GetComponent<Rigidbody2D>();

        //Set player weapon
        weapon = new Weapon("Player Weapon", weaponDamage, bulletSpeed);
    }
    private void Update()
    {
        health.RegenHealth();
    }
    public override void Move(Vector2 direction, Vector2 target)
    {
        playerRB.velocity = speed * Time.deltaTime * direction;

        var playerScreenPos = cam.WorldToScreenPoint(transform.position);
        target.x -= playerScreenPos.x;
        target.y -= playerScreenPos.y;

        float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public override void Shoot()
    {
        Debug.Log($"Shooting a bullet");
        weapon.Shoot(bulletPrefab, this, "Enemy");

    }

    public override void Die()
    {
        Debug.Log("player Died");
        Destroy(gameObject);
    }

    public override void Attack(float interval)
    {

    }

    public override void GetDamage(float damage)
    {
        health.DeductHealth(damage);
        if (health.GetHealth() <= 0)
        {
            Die();
        }
    }
}
