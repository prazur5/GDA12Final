using System.Collections;
using System.Collections.Generic;
using UnityEngine;









public class EnemySpawn : MonoBehaviour
{
    public GameObject objectToSpawn;

    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        Vector3 spawnPosition = transform.position + new Vector3(Random.Range(-300f, 300f), 0, Random.Range(-300f, 300f));
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}



