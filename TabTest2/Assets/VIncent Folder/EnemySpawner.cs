using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    float spawnRate = 1;
    [SerializeField] GameObject shipPrefab;
    new Vector2 spawnPosition;

    void Start()
    {
        StartCoroutine(SpawnShips());
    }

    IEnumerator SpawnShips()
    {
        while (true)
        {
            spawnPosition = transform.position + new Vector3(Random.Range(-9, 9), 6f);
            Instantiate(shipPrefab, spawnPosition, transform.rotation = new Quaternion(0, 0, 180, 0));
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
