using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public float invincibilityTime = 1.0f;
    
    private int currentHealth;
    private float invTimer;
    void Start()
    {
        currentHealth = maxHealth;
        UIManager.Instance.UpdateHealth(currentHealth);
    }

    void Update()
    {
        if (invTimer > 0f) invTimer -= Time.deltaTime;
    }

    public void TakeDamage(int amount)
    {
        if (invTimer > 0f) return;

        currentHealth -= amount;
        invTimer = invincibilityTime;

        UIManager.Instance.UpdateHealth(currentHealth);

        if (currentHealth <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
