using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            SpawnEnemies();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnEnemies()
    {
        int randomSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[0], spawnPoints[randomSpawnPoint].position, transform.rotation);
    }
}
