using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject spawnObejct;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < 100; i++)
            Instantiate(spawnObejct, spawnPoints[Random.Range (0, spawnPoints.Length)].position,Quaternion.identity);
        }
    }
}
