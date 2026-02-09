using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health;
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            // gây damage cho player
            playerHealth.TakeDamage(damage);

            // enemy tự chết
            health.TakeDamage(999);
        }
    }
}
