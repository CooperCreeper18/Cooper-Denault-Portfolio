using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Cooper Denault
 * Assignment 5B
 * Makes objects have health and can take damage
 */

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }
}
