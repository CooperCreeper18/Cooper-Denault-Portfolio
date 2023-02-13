using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (Creation of a long john donut)
 */


public class LongJohnDonut : Donut
{
    public LongJohnDonut()
    {
        this.description = "You made a Long John Donut";
    }

    public override int getSugarAmount()
    {
        return 115;
    }

}
