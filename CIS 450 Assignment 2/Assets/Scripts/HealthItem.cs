using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (UI Manager)
 * (Assignment 2)
 * (health item feedback)
 */



public class HealthItem : Items, IUsingItem 
{
    public override void Use()
    {
       Destroy(gameObject);
    }
}
