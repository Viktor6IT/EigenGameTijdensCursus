using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy;
    private float spawnrangeZ = 24;
    private float spawnrangeX= 24;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnEnemy()
    {
        float randomX = Random.Range(-spawnrangeX, spawnrangeX);
        float randomZ = Random.Range(-spawnrangeZ, spawnrangeZ);

        Vector3 spawnPos = new Vector3(randomX, 0.5f, randomZ);

        Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
    }
}
