using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float spawnInterval = 5f;
    public float maxX = 5f;
    public float maxY = 4f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomPrefab", 0f, spawnInterval);
    }

    private void SpawnRandomPrefab()
    {
        GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];

        float randomX = Random.Range(-maxX, maxX);
        float randomY = Random.Range(-maxY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
