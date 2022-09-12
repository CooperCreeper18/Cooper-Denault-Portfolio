using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = Random.Range( 3.0f, 5.0f );


    public DisplayHealth healthsystem;
    public DisplayScore  scoresystem;

    // Start is called before the first frame update
    void Start()
    {

        healthsystem = GameObject.FindGameObjectWithTag("DisplayHealthText").GetComponent<DisplayHealth>();
        scoresystem = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //add a 1 second delay before first spawning objects
        yield return new WaitForSeconds(startDelay);

        while (healthsystem.gameOver == false && scoresystem.gameOver == false)
        {
            SpawnRandomBall();

            float randomDelay = Random.Range(3.0f, 5.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }



    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int prefabIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[prefabIndex].transform.rotation);
    }

}
