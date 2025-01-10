using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector2 direction; // Riktningen kulan ska r�ra sig i
    private float speed;       // Kulans hastighet
    public float lifeTime = 2f; // Hur l�nge kulan lever

    void Start()
    {
        // F�rst�r kulan efter en viss tid
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Flytta kulan i angiven riktning
        transform.Translate(new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime);
    }

    public void SetDirection(Vector2 newDirection, float newSpeed)
    {
        direction = newDirection.normalized; // S�tter riktningen
        speed = newSpeed;                   // S�tter hastigheten
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // F�rst�r kulan vid kollision
        Destroy(gameObject);
    }
}