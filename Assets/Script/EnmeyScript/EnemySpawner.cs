using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float timer = 0.5f;
    public float min_X = -2.25f, max_X = 2.25f;
    public GameObject[] astroid_Prefabs;
    public GameObject enemyPrefabs;


    void Start()
    {
        Invoke("SpawnEnemies", timer);
    }

    void Update()
    {
    }

    void SpawnEnemies()
    {
        float pos_X = Random.Range(min_X, max_X);
        Vector3 temp = transform.position;
        temp.x = pos_X;

        if (Random.Range(0, 2) > 0)
        {
            Instantiate(astroid_Prefabs[Random.Range(0, astroid_Prefabs.Length)], temp, Quaternion.identity);
        }
        else
        {
            Instantiate(enemyPrefabs, temp, Quaternion.Euler(0f, 0f, 90f));
                
        }

        Invoke("SpawnEnemies", timer);
    }
}