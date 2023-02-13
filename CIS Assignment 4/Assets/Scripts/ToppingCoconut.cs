using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (allows coconut to be added as topping and change text)
 */

public class ToppingCoconut : ToppingDecorator
{
    Donut donut;

    public ToppingCoconut(Donut donut)
    {
        this.donut = donut;
    }

    public override string getDescription()
    {
        return donut.getDescription() + " with Coconut";
    }

    public override int getSugarAmount()
    {
        return donut.getSugarAmount() + 10;
    }
}
