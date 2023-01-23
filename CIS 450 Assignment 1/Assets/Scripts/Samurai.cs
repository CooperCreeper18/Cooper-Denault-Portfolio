using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Cooper Denault
 * Console Output
 * Assignment 1
 * Makes samurai
 */

public class Samurai : Hero, Stealth, Horse
{
    private int honor = 200;


    public override void AttackPower()
    {
        Debug.Log(" The Samurai has 20 Attack Power.");
    }

    public void Stealth()
    {
        Debug.Log("The Samurai can silently kill.");
    }

    public void Honor()
    {
        Debug.Log("The Samurai has " + honor + " honor.");
    }

    public void HorseSpeed()
    {
        Debug.Log(" The Samurai has a strong horse.");
    }

}


