using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab för kulan
    public Transform firePoint;     // Position där kulan skapas
    public float bulletSpeed = 10f; // Kulans hastighet

    void Update()
    {
        // Skjuter när spelaren trycker på vänster musknapp
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Kontrollera att bulletPrefab och firePoint är tilldelade
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogError("BulletPrefab eller FirePoint saknas!");
            return;
        }

        // Skapa kulan
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // Ställ in kulans rörelse
        BulletScript bulletScript = bullet.GetComponent<BulletScript>();
        if (bulletScript != null)
        {
            bulletScript.SetDirection(Vector2.up, bulletSpeed); // Rakt upp
        }
        else
        {
            Debug.LogError("BulletPrefab saknar BulletScript!");
        }
    }
}