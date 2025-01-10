using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float enemySpeed = 1f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Move());
    }

    void Update()
    {
        
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    IEnumerator Move()
    {
        while (true)
        {
            rb.linearVelocity = new Vector2(0, 0);
            rb.linearVelocity = new Vector2(0, enemySpeed) * -1;
            yield return new WaitForSeconds(1f);
            rb.linearVelocity = new Vector2(1, 0);
            yield return new WaitForSeconds(1f);
            rb.linearVelocity = new Vector2(0, 0);
            rb.linearVelocity = new Vector2(-1, 0);
            yield return new WaitForSeconds(1f);
        }
    }
}
