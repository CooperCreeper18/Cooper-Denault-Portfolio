using System.Collections.Generic;
using UnityEngine;
using static UnityEditorInternal.ReorderableList;

/*
 *Cooper enault
 * Game Controller
 * Assignemnt 9 Easy
 * This class calls the references to the different objects in the scene
 */



public class GameController : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject creeperObj;
    public GameObject skeletonObj;

    //A list that will hold all enemies
    List<EnemyType> enemies = new List<EnemyType>();


    void Start()
    {
        //Add the enemies we have
        enemies.Add(new Creeper(creeperObj.transform));
        enemies.Add(new Skeleton(skeletonObj.transform));
    }


    void Update()
    {
        //Update all enemies to see if they should change state and move/attack player
        for (int i = 0; i < enemies.Count; i++)
        {
            enemies[i].UpdateEnemy(playerObj.transform);
        }
    }
}