using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnRate = 3f;
    
    public float minXAxisSpawnValue;
    public float maxXAxisSpawnValue;
    //public Transform minXSpawnTransform

    public float yAxisSpawnValue = 4f;

    private float timeSinceLastAction = 0f;

    public List<GameObject> spawnedEnemies = new List<GameObject>();


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timeSinceLastAction += Time.deltaTime;
        //timeSinceLastAction = timeSinceLastAction + Time.deltaTime;
        //ctrl+RR

        if (timeSinceLastAction >= spawnRate)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        float xPosition = Random.Range(minXAxisSpawnValue, maxXAxisSpawnValue);
        Vector2 spawnPosition = new Vector2(xPosition, yAxisSpawnValue);
        GameObject spawnedEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, this.transform);

        timeSinceLastAction = 0f;

        spawnedEnemies.Add(spawnedEnemy);
    }
}
