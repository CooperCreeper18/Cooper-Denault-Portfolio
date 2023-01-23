using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Cooper Denault
 * Console Output
 * Assignment 1
 * Makes ninja
 */

public class Ninja : Hero, Stealth
{
    private int honor = 100;


    public override void AttackPower()
    {
        Debug.Log(" The ninja has 10 Attack Power.");
    }

    public void Stealth()
    {
        Debug.Log("The ninja can sneak around.");
    }

    public void Honor()
    {
        Debug.Log("The Ninja has " + honor + " honor.");
    }
}


