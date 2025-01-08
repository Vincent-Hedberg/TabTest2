using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab; // Drag your bullet prefab here
    public Transform firePoint; // The point where bullets spawn
    public float bulletSpeed = 20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Default "Fire1" is left mouse button
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Create a bullet at the fire point
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Add velocity to the bullet
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * bulletSpeed;

        // Optional: Destroy bullet after a few seconds
        Destroy(bullet, 2f);
    }
}