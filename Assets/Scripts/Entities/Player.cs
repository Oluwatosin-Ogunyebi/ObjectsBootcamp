using UnityEngine;

public class Player : PlayableObject //Inheritance (is a)
{
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;

    private Rigidbody2D playerRB;
    
    public void Start()
    {
        health = new Health(100);
        playerRB = GetComponent<Rigidbody2D>();
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

    public override void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public override void Die()
    {
        Debug.Log("player Died");
    }

    public override void Attack(float interval)
    {

    }

    public override void GetDamage(float damage)
    {

    }
}
