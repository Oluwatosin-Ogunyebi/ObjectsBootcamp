using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float speed;

    private string targetTag;

    public void SetBullet(float _damage, string _targetTag, float _speed = 10)
    {
        damage = _damage;
        targetTag = _targetTag;
        speed = _speed;
    }

    private void Update()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
        Debug.Log($"Bullet is moving to deal a damage of {damage}");
    }

    void Damage(IDamageable damageable)
    {
        if (damageable != null)
        {
            damageable.GetDamage(damage);

            GameManager.GetInstance().scoreManager.IncrementScore();
            Destroy(gameObject);
        }
        Debug.Log("Damaged Something!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        //Checks the target
        if (!collision.gameObject.CompareTag(targetTag)) return;

        IDamageable damageable = collision.GetComponent<IDamageable>();
        Damage(damageable);

    }
}
