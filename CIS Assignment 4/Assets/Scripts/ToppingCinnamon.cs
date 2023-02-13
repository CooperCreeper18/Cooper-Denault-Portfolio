using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (allows cinnamon to be added as topping and change text)
 */

public class ToppingCinnamon : ToppingDecorator
{
    Donut donut;

    public ToppingCinnamon(Donut donut)
    {
        this.donut = donut;
    }

    public override string getDescription()
    {
        return donut.getDescription() + " with Cinnamon";
    }

    public override int getSugarAmount()
    {
        return donut.getSugarAmount() + 50;
    }
}
