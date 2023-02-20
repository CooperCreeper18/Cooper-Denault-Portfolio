using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * (Cooper Denault)
 * (MonsterSpawner)
 * (Assignment 5)
 * (This is the basic for spawning aspect, here i can access the factory the create the specific monster and then the 
 * methods here are what the buttons call when they are pressed, what is also here is the addition of the boundries 
 * for the monsters spawning)
 */


public class MonsterSpawner : MonoBehaviour
{
    private GameObject monster;
    public MonsterFactory factory;
    public float spawnDistance;
    private Transform playerOrCameraTransform;

    private void Start()
    {
        spawnDistance = 20f;
        playerOrCameraTransform = Camera.main.transform;
    }

    public void SpawnMonster(string type)
    {
        monster = factory.CreateMonster(type);

        float xRand = Random.Range(-15, 15);
        float zRand = Random.Range(-15, 15);


        Vector3 spawnPos = playerOrCameraTransform.position + playerOrCameraTransform.forward * spawnDistance + new Vector3(xRand, 0, zRand);
        GameObject monsterInstance = Instantiate(monster, spawnPos, playerOrCameraTransform.rotation);


        if (type.Equals("Pizza"))
        {
            monsterInstance.AddComponent<Pizza>();
        }
        else if (type.Equals("GummyBear"))
        {
            monsterInstance.AddComponent<GummyBear>();
        }
        else if (type.Equals("Spaghetti"))
        {
            monsterInstance.AddComponent<Spaghetti>();
        }
        else if (type.Equals("Burger"))
        {
            monsterInstance.AddComponent<Burger>();
        }
    }
}
