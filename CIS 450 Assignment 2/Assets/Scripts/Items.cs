using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * (Cooper Denault)
 * (UI Manager)
 * (Assignment 2)
 * (allows other items to use Use())
 */


public abstract class Items : MonoBehaviour
{
    public abstract void Use();

    IUsingItem usingItem;

    // Update is called once per frame
    void Update()
    {
        
    }
}
