using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Cooper Denault
 * Assignment 2 Prototype 
 * When entering a TriggerZone, changes the score
 */


//attach this to player
public class PlayerEnterTrigger : MonoBehaviour
{
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
    
}
