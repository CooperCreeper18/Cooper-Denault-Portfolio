using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * (Cooper Denault)
 * (UI Manager)
 * (Assignment 2)
 * (key item feedback)
 */



public class KeyItem : Items, IUsingItem
{

    public override void Use()
    {

        Destroy(gameObject);

    }

    

}
