using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefeb;
    private float spwanRange = 9.0f;
    void Start()
    {
        //Instantiate(enemyPrefeb, new Vector3(0, 0, 6), enemyPrefeb.transform.rotation);//new Vector3(0, 0, 6) for random coordinate.
        Instantiate(enemyPrefeb, GenarateSpawnPosition(), enemyPrefeb.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenarateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spwanRange, spwanRange);
        float spawnPosZ = Random.Range(-spwanRange, spwanRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
