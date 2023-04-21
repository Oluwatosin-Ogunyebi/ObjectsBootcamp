using UnityEngine;

public class Bullet : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IDamageable damageable = collision.otherCollider.GetComponent<IDamageable>();
        if (damageable != null)
        {
            damageable.GetDamage(damage);
        }
    }
}
