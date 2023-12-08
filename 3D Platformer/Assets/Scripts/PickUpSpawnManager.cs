using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawnManager : MonoBehaviour
{
    public GameObject[] pickupPrefabs;

    [SerializeField]
    private float spawnRangeX = 45.0f;
    private float spawnRangeY = 55.0f;

    private float startDelay = 2f;
    private float spawnInterval = 8f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPickUp", startDelay, spawnInterval);
    }

    void SpawnRandomPickUp()
    {
        // Generate a position to spawn at
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(4, spawnRangeY), 0);
        // Pick a random pickup from array
        int pickupIndex = Random.Range(0,pickupPrefabs.Length);
        // Spawn pickup indexed from the array
        Instantiate(pickupPrefabs[pickupIndex], spawnPos, pickupPrefabs[pickupIndex].transform.rotation);
    }
}
