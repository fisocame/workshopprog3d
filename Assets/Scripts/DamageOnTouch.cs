using UnityEngine;

public class DamageOnTouch : MonoBehaviour
{
    public int damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Player")) return;

        PlayerHealth health = collision.collider.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }

    }
}
