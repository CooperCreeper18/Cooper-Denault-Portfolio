using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (Creation of a jelly donut)
 */


public class JellyDonut : Donut
{
    public JellyDonut()
    {
        this.description = "You made a Jelly Donut";
    }

    public override int getSugarAmount()
    {
        return 80;
    }

}
