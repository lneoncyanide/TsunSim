using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{


    public float spawnTimer = 2f;
    public float spawnDelay = 1f;
    public GameObject ObstaclePrefab;
    public float SpawnX = 10f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= spawnTimer)
        {
            SpawnObstacles();
            spawnTimer = Time.time + spawnDelay;

        }
    }
    void SpawnObstacles()
    {
        int random = Random.Range(-9, 10);
        Vector2 randomCoordinates = new Vector2(SpawnX, random);
        Instantiate(ObstaclePrefab, randomCoordinates, Quaternion.identity);
    }
}
