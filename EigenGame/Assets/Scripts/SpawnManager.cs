using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy;
    private float spawnrangeZ = 24;
    private float spawnrangeX= 24;
    private int waveNumber = 3;
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            waveNumber += 2;
            spawnEnemy(waveNumber);
        }
    }
    void spawnEnemy(int enemiesToSpawn)
    {
       

        for (int i = 0; i < enemiesToSpawn; i ++)
        {
            Instantiate(Enemy, generateSpawnPosition(), Enemy.transform.rotation);
        }
    }
    private Vector3 generateSpawnPosition()
    {
        float randomX = Random.Range(-spawnrangeX, spawnrangeX);
        float randomZ = Random.Range(-spawnrangeZ, spawnrangeZ);

        Vector3 spawnPos = new Vector3(randomX, 0.5f, randomZ);
        return spawnPos;
    }
}
