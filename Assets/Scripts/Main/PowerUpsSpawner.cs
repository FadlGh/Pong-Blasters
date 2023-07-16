using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private GameObject ball;
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private float maxX = 5f;
    [SerializeField] private float maxY = 4f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomPrefab", 0f, spawnInterval);
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Ball").Length == 0) 
        {
            Instantiate(ball, new Vector2(0f ,0f), Quaternion.identity);
        }
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
