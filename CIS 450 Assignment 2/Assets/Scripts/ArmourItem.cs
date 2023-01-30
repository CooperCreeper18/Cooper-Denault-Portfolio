using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (UI Manager)
 * (Assignment 2)
 * (armour item feedback)
 */



public class ArmourItem : Items, IUsingItem
{
    public override void Use()
    {
        Destroy(gameObject);
    }
}
