using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100; // Max health for the object

    public void TakeDamage(int damage)
    {
        health -= damage; // Subtract damage from health
        Debug.Log($"{gameObject.name} took {damage} damage. Remaining health: {health}");

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{gameObject.name} has died!");
        Destroy(gameObject); // Destroy the object when health is zero
    }
}