using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Cooper Denault
 * Assignment 2 Prototype 
 * Provides the losing condition when falling off the edge
 */


//attach this script to the player
public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame

    void Update()
    {
        
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }

    }
}
