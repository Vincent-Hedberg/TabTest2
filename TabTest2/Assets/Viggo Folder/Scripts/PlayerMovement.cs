using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Rigidbody2D rigidbody;
    private Vector2 movementDirection;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var pos = transform.position;

        pos.x = Mathf.Clamp(transform.position.x, -8.4f, 8.4f);
        pos.y = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);

        transform.position = pos;

        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = movementDirection * moveSpeed;
    }
}
