using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (UI Manager)
 * (Assignment 2)
 * (special item process)
 */



public class SpecialItem : Items, IUsingItem
{



    public override void Use()
    {
        Destroy(gameObject);
    }
}
