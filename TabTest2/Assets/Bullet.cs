using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; // Bullet speed
    public int damage = 10;   // Damage dealt by the bullet
    public float lifetime = 2f; // Time before the bullet is destroyed

    void Start()
    {
        // Destroy the bullet after a certain lifetime to avoid clutter
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Move the bullet forward based on its local forward direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Log what the bullet hits
        Debug.Log($"Bullet hit: {other.name}");

        // Check if the object has a Health component
        Health target = other.GetComponent<Health>();
        if (target != null)
        {
            target.TakeDamage(damage); // Apply damage
        }

        // Destroy the bullet on impact
        Destroy(gameObject);
    }
}
