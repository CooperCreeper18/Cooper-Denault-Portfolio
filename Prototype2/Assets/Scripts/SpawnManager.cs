using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //set this array of references in the inspector
    public GameObject[] prefabsToSpawn;

    //variables for spawn position
    private float leftBound = -19;
    private float rightBound = 19;
    private float spawnPosZ = 25;

    void Start()
    {
        InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
          //  SpawnRandomPrefab();
        }
    }

    void SpawnRandomPrefab()
    {
        //pick a random animal index
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate a random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn our animal
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
