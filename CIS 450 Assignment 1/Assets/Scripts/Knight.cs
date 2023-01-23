using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Hero, Horse
{
    private int armour = 25;

    public override void AttackPower()
    {
        Debug.Log(" The Knight has 15 Attack Power.");
    }

    public void HorseSpeed()
    {
        Debug.Log(" The Knight has a fast horse.");
    }


    public void GetArmour()
    {
        Debug.Log("The Knight has " + armour + " armour.");
    }
}


