using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DeerSpawner : MonoBehaviour
{
    public GameObject deer_male_prefab;
    public int initialDeer = 100; // Initial Number of deer to spawn
    public float spawnRadius = 100f; // Radius within whic deer will be spawned
    public int minNumberOfDeer = 50; // Minimum number of deer to maintain
    public float checkInterval = 5f; // Time interval between checks
    public LayerMask terrainLayer; // Layer mask for terrain
    public LayerMask obstacleLayer; // Layer mask for obstacles like buildings
    void Start()
    {
        SpawnDeer(initialDeer);
        StartCoroutine(CheckAndRespawnDeer());
    }

    void SpawnDeer(int numberOfDeer)
    {
        for (int i = 0; i < numberOfDeer; i++)
        {
            Vector3 spawnPosition;
            if(FindValidSpawnPosition(out spawnPosition))
            {
                GameObject deer = Instantiate(deer_male_prefab, spawnPosition, Quaternion.identity);
                deer.transform.SetParent(transform); // Set the spawner as parent to organize hierarchy
            }
        }
    }

    IEnumerator CheckAndRespawnDeer()
    {
        while (true)
        {
            yield return new WaitForSeconds(checkInterval);
            int currentDeerCount = CountDeer();
            if (currentDeerCount < minNumberOfDeer)
            {
                SpawnDeer(minNumberOfDeer - currentDeerCount);
            }
        }
    }

    int CountDeer()
    {
        return GameObject.FindGameObjectsWithTag("Deer").Length;
    }

    bool FindValidSpawnPosition(out Vector3 spawnPosition)
    {
        for (int attempt = 0; attempt < 30; attempt++) // Try 30 times to find a valid position
        {
            Vector3 randomDirection = Random.insideUnitSphere * spawnRadius;
            randomDirection += transform.position;
            randomDirection.y = 0; // Flatten the random position to the ground level

            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomDirection, out hit, spawnRadius, NavMesh.AllAreas))
            {
                if (Physics.Raycast(hit.position, Vector3.down, out RaycastHit groundHit, Mathf.Infinity, terrainLayer) &&
                    !Physics.CheckSphere(hit.position, 1f, obstacleLayer)) // Ensure the spawn point is on the terrain and not inside an obstacle
                    {
                        spawnPosition = groundHit.point;
                        return true;
                    }
            }
        }
        spawnPosition = Vector3.zero;
        return false;
    }

    void Update()
    {
        
    }
}
