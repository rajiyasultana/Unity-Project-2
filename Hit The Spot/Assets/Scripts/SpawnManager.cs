using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefeb;
    public GameObject powerupPrefab;
    private float spwanRange = 9.0f;
    public int enemyCount = 0;
    public int waveNumber = 1;
    void Start()
    {
        //Instantiate(enemyPrefeb, new Vector3(0, 0, 6), enemyPrefeb.transform.rotation);//new Vector3(0, 0, 6) for random coordinate.
        SpawnEnemyWave(waveNumber);
        SpawnPowerupPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPowerupPrefab();
        }
    }

    void SpawnEnemyWave(int enmeytoSpwan)
    {
        for (int i = 0; i < enmeytoSpwan; i++)
        {
            Instantiate(enemyPrefeb, GenarateSpawnPosition(), enemyPrefeb.transform.rotation);
        }
    }

    void SpawnPowerupPrefab()
    {
        Instantiate(powerupPrefab, GenarateSpawnPosition(), powerupPrefab.transform.rotation);
    }
    private Vector3 GenarateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spwanRange, spwanRange);
        float spawnPosZ = Random.Range(-spwanRange, spwanRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
