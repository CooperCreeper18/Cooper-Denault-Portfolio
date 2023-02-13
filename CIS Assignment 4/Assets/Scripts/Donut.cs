using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (Creates a Donut as the main component class)
 */

public abstract class Donut
{
    public string description = "Unknown";

    public virtual string getDescription()
    {
        return description;
    }

    public abstract int getSugarAmount();


}
