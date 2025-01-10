using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector2 direction; // Riktningen kulan ska röra sig i
    private float speed;       // Kulans hastighet
    public float lifeTime = 2f; // Hur länge kulan lever

    void Start()
    {
        // Förstör kulan efter en viss tid
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Flytta kulan i angiven riktning
        transform.Translate(new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime);
    }

    public void SetDirection(Vector2 newDirection, float newSpeed)
    {
        direction = newDirection.normalized; // Sätter riktningen
        speed = newSpeed;                   // Sätter hastigheten
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Förstör kulan vid kollision
        Destroy(gameObject);
    }
}