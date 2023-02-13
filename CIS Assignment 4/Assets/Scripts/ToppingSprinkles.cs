using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (allows sprinles to be added as topping and change text)
 */

public class ToppingSprinkles : ToppingDecorator
{
    Donut donut;

    public ToppingSprinkles(Donut donut)
    {
        this.donut = donut;
    }

    public override string getDescription()
    {
        return donut.getDescription() + " with Sprinkles";
    }

    public override int getSugarAmount()
    {
        return donut.getSugarAmount() + 100;
    }
}
