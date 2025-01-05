using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 3f;

    public GameObject meteorPrefab;
    public float spawnRate2 = 6f;

    public float minXAxisSpawnValue;
    public float maxXAxisSpawnValue;
    //public Transform minXSpawnTransform

    public float yAxisSpawnValue = 4f;

    private float timeSinceLastAction = 0f;
    private float timeSinceLastAction2 = 0f;

    public List<GameObject> spawnedEnemies = new List<GameObject>();

    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        GameManager.enemySpawner = this;
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        
        timeSinceLastAction += Time.deltaTime;
        timeSinceLastAction2 += Time.deltaTime;

        //timeSinceLastAction = timeSinceLastAction + Time.deltaTime;
        //ctrl+RR

        if (timeSinceLastAction >= spawnRate)
        {
            SpawnEnemy();
        }
        if (timeSinceLastAction2 >= spawnRate2)
        {
            SpawnMeteor();
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

    void SpawnMeteor()
    {
        float xPosition = Random.Range(minXAxisSpawnValue, maxXAxisSpawnValue);
        Vector2 spawnPosition = new Vector2(xPosition, yAxisSpawnValue);
        GameObject spawnedEnemy = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity, this.transform);

        timeSinceLastAction2 = 0f;

        spawnedEnemies.Add(spawnedEnemy);
    }
    public void enemy_destroyed()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
