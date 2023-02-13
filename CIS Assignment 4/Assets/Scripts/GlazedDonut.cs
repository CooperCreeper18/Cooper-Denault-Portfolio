using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (Creation of a glazed donut)
 */


public class GlazedDonut : Donut
{
    public GlazedDonut()
    {
        this.description = "You made a Glazed Donut";
    }

    public override int getSugarAmount()
    {
        return 180;
    }

}
