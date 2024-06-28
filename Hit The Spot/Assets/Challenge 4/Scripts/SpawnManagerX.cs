﻿using System.Collections;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public GameObject player;

    private float spawnRangeX = 10;
    private float spawnZMin = 15; // set min spawn Z
    private float spawnZMax = 25; // set max spawn Z
     
    public int enemyCount;
    public int waveCount = 1;

    private bool isSpawning = false;


    
    void Start()
    {
        //Instantiate(enemyPrefeb, new Vector3(0, 0, 6), enemyPrefeb.transform.rotation);//new Vector3(0, 0, 6) for random coordinate.
        SpawnEnemyWave(3);
        SpawnPowerupPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;


        if (enemyCount == 0 && !isSpawning)
        {
            waveCount++;
            SpawnEnemyWave(1);
            //SpawnPowerupPrefab();
        }

    }

    // Generate random spawn position for powerups and enemy balls
    Vector3 GenerateSpawnPosition ()
    {
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }

    void SpawnPowerupPrefab()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }


    void SpawnEnemyWave(int enemytoSpawn)
    {
        for(int i = 0; i < enemytoSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

    }

    // Move player back to position in front of own goal
    /*void ResetPlayerPosition ()
    {
        player.transform.position = new Vector3(0, 1, -7);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }*/

}