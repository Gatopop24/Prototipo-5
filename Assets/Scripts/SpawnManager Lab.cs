using UnityEngine;

public class SpawnManagerLab : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;
    private float xEnemySpawn = -10.0f;
    private float zSpawnRange = 10.0f;
    private float xPowerupRange = 5.0f;
    private float ySpawn = 0.75f;
    private float powerupSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        float randomZ = Random.Range(-zSpawnRange, zSpawnRange );
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(xEnemySpawn, ySpawn, randomZ);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
        float randomX = Random.Range(-xPowerupRange, xPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);

    }
}
