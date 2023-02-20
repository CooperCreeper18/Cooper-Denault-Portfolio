using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (MonsterFactory)
 * (Assignment 5)
 * (This is the basic for the factory design idea, here i can add the prefabs for the individual objects 
 * and set which objects are spawned when the buttons are pressed)
 */


public class MonsterFactory : MonoBehaviour
{
    public GameObject PizzaPrefab;
    public GameObject BurgerPrefab;
    public GameObject SpaghettiPrefab;
    public GameObject GummyBearPrefab;

    private GameObject monsterToSpawn;

    public GameObject CreateMonster(string type)
    {
        monsterToSpawn = null;

        if (type.Equals("Pizza"))
        {
            monsterToSpawn = PizzaPrefab;
        }
        else if (type.Equals("Burger"))
        {
            monsterToSpawn = BurgerPrefab;
        }
        else if (type.Equals("Spaghetti"))
        {
            monsterToSpawn = SpaghettiPrefab;
        }
        else if (type.Equals("GummyBear"))
        {
            monsterToSpawn = GummyBearPrefab;
        }
        return monsterToSpawn;
    }

}
