using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefabs;

    float pointPosition = 9;

    private void Start()
    {
        Instantiate(enemyPrefabs, Spawn(), enemyPrefabs.transform.rotation);
    }

    Vector3 Spawn()
    {
        float pointX = Random.Range(-pointPosition, pointPosition);
        float pointZ = Random.Range(-pointPosition, pointPosition);

        Vector3 position = new Vector3(pointX, 0, pointZ);

        return position;
 
    }
}
