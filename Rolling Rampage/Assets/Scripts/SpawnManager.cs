using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] GameObject enemyPrefabs;

    [Header("Enemy Number")]
    [SerializeField] int enemyCount;
    [SerializeField] int waveNumber = 1;


    [SerializeField] GameObject powerupPrefabs;

    float pointPosition = 9;

    private void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefabs, Spawn(), powerupPrefabs.transform.rotation);
    }

    private void Update()
    {
        enemyCount = FindObjectsOfType<EnemyController>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefabs, Spawn(), powerupPrefabs.transform.rotation);
        }
    }

    void SpawnEnemyWave(int enemyToSpwn)
    {
        for (int i = 0; i < enemyToSpwn; i++)
        {
            Instantiate(enemyPrefabs, Spawn(), enemyPrefabs.transform.rotation);
        }
    }

    Vector3 Spawn()
    {
        float pointX = Random.Range(-pointPosition, pointPosition);
        float pointZ = Random.Range(-pointPosition, pointPosition);

        Vector3 position = new Vector3(pointX, 0, pointZ);

        return position;
 
    }
}
