using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;



    private void Start()
    {
        currentHealth = maxHealth;
 
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Add death behavior here, e.g., play death animation, disable GameObject, etc.
        Destroy(gameObject);
    }
}
