using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefab;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomUFO()
    {
        
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int ufoIndex = Random.Range(0,ufoPrefab.Length); // Picks Random UFO from array
            Instantiate(ufoPrefab[ufoIndex], spawnPos, ufoPrefab[ufoIndex].transform.rotation); // Spawns indexed UFO from array
            
    }
}
