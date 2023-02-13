using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (Creation of a frosted donut)
 */


public class FrostedDonut : Donut
{
    public FrostedDonut()
    {
        this.description = "You made a Frosted Donut";
    }

    public override int getSugarAmount()
    {
        return 100;
    }

}
